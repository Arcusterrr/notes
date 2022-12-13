using Microsoft.EntityFrameworkCore;
using Notes.Domain;

namespace Notes.Application.interfaces;

public interface INotesDbContext
{
    public DbSet<Note> Notes { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}