namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the content of the document or part of the document.
/// This class extends <see cref = "ModelElementCollection{StoryContent}"/> and contains block-level markup, allowing elements such as paragraphs, tables, and other block content to exist as siblings within the document structure.
/// </summary>
[OpenXmlType(typeof(CommonContent<IStoryContent>))]
[XmlRoot("Story", Namespace = "DocumentModel.Wordprocessing")]
public partial class Story<OpenXmlCollectionType>: ModelElementCollection<ModelElement, OpenXmlCollectionType>
  where OpenXmlCollectionType: DX.OpenXmlCompositeElement
{
  private readonly Dictionary<Type, Type> _modelElementTypeMapping = new()
  {
    { typeof(DXW.Paragraph), typeof(DMW.Paragraph) },
    { typeof(DXW.Table), typeof(DMW.Table) },
    { typeof(DXW.AltChunk), typeof(DMW.AltChunk) },
    { typeof(DXW.SdtBlock), typeof(DMW.SdtBlock) },
    { typeof(DXW.BookmarkStart), typeof(DMW.BookmarkStart) },
    { typeof(DXW.ContentPart), typeof(DMW.ContentPart) },
    { typeof(DXW.CustomXmlBlock), typeof(DMW.CustomXmlBlock) },
    { typeof(DXW.CustomXmlInsRangeEnd), typeof(DMW.CustomXmlInsRangeEnd) },
    { typeof(DXW.CustomXmlDelRangeEnd), typeof(DMW.CustomXmlDelRangeEnd) },
    { typeof(DXW.CustomXmlMoveFromRangeEnd), typeof(DMW.CustomXmlMoveFromRangeEnd) }, 
    { typeof(DXW.CustomXmlMoveFromRangeEnd), typeof(DMW.CustomXmlMoveFromRangeEnd) },
    { typeof(DXW.CustomXmlMoveToRangeEnd), typeof(DMW.CustomXmlMoveToRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeEnd), typeof(DMW.CustomXmlConflictInsertionRangeEnd) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeEnd), typeof(DMW.CustomXmlConflictDeletionRangeEnd) },
    { typeof(DXW.BookmarkEnd), typeof(DMW.BookmarkEnd) },
    { typeof(DXW.CommentRangeStart), typeof(DMW.CommentRangeStart) },
    { typeof(DXW.CommentRangeEnd), typeof(DMW.CommentRangeEnd) },
    { typeof(DXW.MoveFromRangeEnd), typeof(DMW.MoveFromRangeEnd) },
    { typeof(DXW.MoveToRangeEnd), typeof(DMW.MoveToRangeEnd) },
    { typeof(DXW.MoveFromRangeStart), typeof(DMW.MoveFromRangeStart) },
    { typeof(DXW.MoveToRangeStart), typeof(DMW.MoveToRangeStart) },
    { typeof(DXW.PermEnd), typeof(DMW.PermEnd) },
    { typeof(DXW.PermStart), typeof(DMW.PermStart) },
    { typeof(DXW.ProofError), typeof(DMW.ProofError) },
    { typeof(DXW.InsertedRun), typeof(DMW.InsertedRun) },
    { typeof(DXW.DeletedRun), typeof(DMW.DeletedRun) },
    { typeof(DXW.MoveFromRun), typeof(DMW.MoveFromRun) },
    { typeof(DXW.MoveToRun), typeof(DMW.MoveToRun) },
    { typeof(DXO10W.RunConflictInsertion), typeof(DMW.RunConflictInsertion) },
    { typeof(DXO10W.RunConflictDeletion), typeof(DMW.RunConflictDeletion) },
    { typeof(DXW.SdtBlock), typeof(DMW.SdtBlock) },
    { typeof(DXW.SectionProperties), typeof(DMW.SectionProperties) },
    { typeof(DXW.CustomXmlInsRangeStart), typeof(DMW.CustomXmlInsRangeStart) },
    { typeof(DXW.CustomXmlDelRangeStart), typeof(DMW.CustomXmlDelRangeStart) },
    { typeof(DXW.CustomXmlMoveFromRangeStart), typeof(DMW.CustomXmlMoveFromRangeStart) },
    { typeof(DXW.CustomXmlMoveToRangeStart), typeof(DMW.CustomXmlMoveToRangeStart) },
    { typeof(DXO10W.CustomXmlConflictInsertionRangeStart), typeof(DMW.CustomXmlConflictInsertionRangeStart) },
    { typeof(DXO10W.CustomXmlConflictDeletionRangeStart), typeof(DMW.CustomXmlConflictDeletionRangeStart) },
  };

  /// <summary>
  /// Loads model elements from the specified Open XML composite element and populates the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element containing child elements to load.</param>
  protected override void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    this.Clear();
    foreach (var openXmlElement in openXmlModeledCollection.Elements())
    {
      var openXmlElementType = openXmlElement.GetType();
      if (!_modelElementTypeMapping.TryGetValue(openXmlElementType, out var modelElementType))
      {
        throw new InvalidOperationException(
          $"No model element type mapping found for Open XML element type {openXmlElementType.FullName}.");
      }
      ModelElement? modelObject = null;
      var constructor = modelElementType.GetConstructor([this.GetType()]);
      if (constructor != null)
      {
        modelObject = (ModelElement)constructor.Invoke([this]);
        this.Add(modelObject);
        modelObject.LoadData(openXmlElement);
      }
      else
      {
        constructor = modelElementType.GetConstructor([openXmlElementType, this.GetType()]);
        if (constructor != null)
        {
          modelObject = (ModelElement)constructor.Invoke([openXmlElement, this]);
        }
        else
        {
          constructor = modelElementType.GetConstructor([openXmlElementType]);
          if (constructor != null)
          {
            modelObject = (ModelElement)constructor.Invoke([openXmlElement]);
            this.Add(modelObject);
          }
          else
          {
            constructor = modelElementType.GetConstructor([]);
            if (constructor != null)
            {
              modelObject = (ModelElement)constructor.Invoke([]);
              Debug.WriteLine(
                $"Warning: Model element of type {modelElementType.FullName} was created using a parameterless constructor. Consider adding a constructor that accepts the parent collection or the Open XML element for better initialization.");
              this.Add(modelObject);
              modelObject.LoadData(openXmlElement);
            }
            else
            {
              throw new InvalidOperationException(
                $"No suitable constructor found for model element type {modelElementType.FullName}.");
            }
          }
        }
      }
    }
  }

  /// <summary>
  /// Updates the Open XML composite element to reflect the current state of the collection.
  /// </summary>
  /// <param name = "openXmlModeledCollection">The Open XML composite element to update.</param>
  protected override void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    SetUpdatableElement(openXmlModeledCollection);
    var children = openXmlModeledCollection.Elements().ToArray();
    foreach (var child in children)
    {
      child.Remove();
    }
    foreach (var item in this)
    {
      if (item is IUpdatable updatable)
      {
        var updatableElement = updatable.GetUpdatableElement();
        if (updatableElement is DX.OpenXmlElement openXmlElement)
        {
          item.UpdateData(openXmlElement);
          openXmlModeledCollection.AppendChild(openXmlElement);
        }
      }
    }
  }
}