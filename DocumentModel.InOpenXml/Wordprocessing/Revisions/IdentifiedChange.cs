namespace DocumentModel.Wordprocessing;
public abstract partial class IdentifiedChange<T> : ModelElement<T>, IIdentifiedChange where T : DX.OpenXmlElement
{
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    public string? Author { get => _Author; set => UpdateField(ref _Author, value, nameof(Author)); }

    private string? _Author;
    public DateTime? Date { get => _Date; set => UpdateField(ref _Date, value, nameof(Date)); }

    private DateTime? _Date;
}