﻿using FirstStep.Data;
using FirstStep.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstStep.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public async Task<Employee> Create(HRManager employee)
        {
            employee.user_id = 0;

            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return employee;
        }

        public async void Delete(int id)
        {
            Employee employee = await GetById(id);

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            Employee? employee = await _context.Employees.FindAsync(id);
            if (employee is null)
            {
                throw new Exception("Employee not found.");
            }

            return employee;
        }

        public async Task<Employee> GetAllHRManagers(int company_Id)
        {
            Employee? employee = await _context.Employees.Where(e => e.is_HRM).FirstOrDefaultAsync(e => e.company_id == company_Id);
            if (employee is null)
            {
                throw new Exception("Employee not found.");
            }

            return employee;
        }

        public async Task<Employee> GetAllHRAssistants(int company_Id)
        {
            Employee? employee = await _context.Employees.Where(e => !e.is_HRM).FirstOrDefaultAsync(e => e.company_id == company_Id);
            if (employee is null)
            {
                throw new Exception("Employee not found.");
            }

            return employee;
        }


        public async void Update(Employee employee)
        {
            Employee dbEmployee = await GetById(employee.user_id);

            dbEmployee.first_name = employee.first_name;
            dbEmployee.last_name = employee.last_name;
            dbEmployee.email = employee.email;
            dbEmployee.password = employee.password;
            dbEmployee.is_HRM = employee.is_HRM;

            await _context.SaveChangesAsync();
        }

    }
}
