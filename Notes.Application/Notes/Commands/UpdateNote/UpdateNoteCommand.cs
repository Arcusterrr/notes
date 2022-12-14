using MediatR;

namespace Notes.Application.Notes.Commands.CreateNote;

public class UpdateNoteCommand : IRequest
{
    public Guid UserId { get; set; }
    public Guid id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    
}