using Microsoft.EntityFrameworkCore;
using Service.DTO;
using ServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKirana.Data.Data;
using TheKirana.Model.Models;

namespace Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;

        public CategoryService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Category> AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<Category?> DeleteAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            return category;

        }

        public async Task UpdateAsync(CategoryDto category, int id)
        {
            var existingCategory = await _context.Categories.FindAsync(id);

            if (existingCategory != null)
            {
                existingCategory.CategoryOfName = category.CategoryOfName;
                existingCategory.CategoryDescription = category.CategoryDescription;
                existingCategory.ImageUrl = category.ImageUrl;
                existingCategory.Products = category.Products;
                _context.Categories.Update(existingCategory);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new KeyNotFoundException($"Category with ID {id} not found.");
            }

        }
    }
}
