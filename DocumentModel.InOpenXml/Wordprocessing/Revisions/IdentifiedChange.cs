namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract base class for changes that have an identifier, author, and date.
/// </summary>
/// <typeparam name="T"></typeparam>
public abstract partial class IdentifiedChange<T>: ModelElement<T>, IIdentifiedChange where T: DX.OpenXmlElement
{
  /// <summary>
  /// Identifier of the change.
  /// </summary>
  public int? Id
  {
    get => _Id;
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private int? _Id;

  /// <summary>
  /// Author of the change.
  /// </summary>
  public string? Author
  {
    get => _Author;
    set => UpdateField(ref _Author, value, nameof(Author));
  }

  private string? _Author;

  /// <summary>
  /// Date of the change.
  /// </summary>
  public DateTime? Date
  {
    get => _Date;
    set => UpdateField(ref _Date, value, nameof(Date));
  }

  private DateTime? _Date;
}