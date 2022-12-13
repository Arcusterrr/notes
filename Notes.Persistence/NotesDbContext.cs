using Microsoft.EntityFrameworkCore;
using Notes.Application.interfaces;
using Notes.Domain;
using Notes.Persistence.EntityTypeConfigurations;

namespace Notes.Persistence;

public class NotesDbContext : DbContext, INotesDbContext
{
    public DbSet<Note> Notes { get; set; }

    public NotesDbContext(DbContextOptions<NotesDbContext> dbContextOptions) : base(dbContextOptions){ }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfiguration(new NoteConfiguration());
        base.OnModelCreating(builder);
    }
}