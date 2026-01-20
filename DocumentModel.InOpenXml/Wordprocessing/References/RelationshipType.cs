namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an abstract base class for defining a strongly-typed relationship element within a document model.
/// </summary>
/// <remarks>This class provides common properties for relationship elements, such as the relationship identifier
/// and target URI. It is intended to be inherited by concrete relationship types that map to specific document
/// relationships.</remarks>
/// <typeparam name="T">The type of the underlying relationship element represented by this class. Must be a type derived from
/// DXW.RelationshipType.</typeparam>
public abstract class RelationshipType<T> : ModelElement<T>
  where T : DXW.RelationshipType
{
  /// <summary>
  /// Gets the underlying Document instance associated with this object.
  /// </summary>

  /// <summary>
  /// Unique identifier for the relationship.
  /// </summary>
  public string? Id
  {
    get => _Id;
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private string? _Id;

  /// <summary>
  /// Attaches the specified WordprocessingDocument and loads its data into the current instance.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and load.</param>
  public override void AttachAndLoad(DXPack.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    if (WordprocessingDocument == null)
      return;
    LoadData(WordprocessingDocument);
  }

  /// <summary>
  /// Attaches the specified WordprocessingDocument and updates the associated data.
  /// </summary>
  /// <param name="wordprocessingDocument">The WordprocessingDocument to attach and use for updating data.</param>
  public override void AttachAndUpdate(DXPack.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    if (WordprocessingDocument == null)
      return;
    UpdateData(WordprocessingDocument);
  }

  /// <summary>
  /// Updates the internal data by loading information from the specified Open XML element.
  /// </summary>
  /// <remarks>If the associated Document is not available, the method does not perform any
  /// update.</remarks>
  /// <param name="openXmlElement">The Open XML element from which to load data. This parameter must represent a valid Open XML element associated
  /// with a Document.</param>
  public override void UpdateData(object openXmlElement)
  {
    if (WordprocessingDocument == null)
      return;
    UpdateData(WordprocessingDocument);
  }

  /// <summary>
  /// Loads data from the specified Document into the current instance.
  /// </summary>
  /// <remarks>This method updates the Id and Uri properties based on the relationship information found in the
  /// provided document, if available. If the relevant relationship is not present, the properties remain
  /// unchanged.</remarks>
  /// <param name="document">The Document from which to load data.</param>
  public virtual void LoadData(DXPack.WordprocessingDocument document)
  {
    DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableOpenXmlElement();
    if (updatedElement != null)
    {
      Id = updatedElement.Id;
    }
  }

  /// <summary>
  /// Updates the specified Document with the current Id and Uri values.
  /// </summary>
  /// <remarks>This method sets the Id property and, if specified, the Uri property on the relationship element
  /// within the provided document. The document must contain a relationship element compatible with the update
  /// operation.</remarks>
  /// <param name="document">The Document to update with new relationship data. Cannot be null.</param>
  public virtual void UpdateData(DXPack.WordprocessingDocument document)
  {
    DXW.RelationshipType? updatedElement = (DXW.RelationshipType?)GetUpdatableOpenXmlElement();
    if (updatedElement != null)
    {
      updatedElement.Id = Id;
    }
  }

}