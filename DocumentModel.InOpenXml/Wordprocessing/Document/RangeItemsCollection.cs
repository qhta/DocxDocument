namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specific collection of Story items in a Wordprocessing document, extending the generic ContentItemsCollection to handle ModelElement types. This collection is designed to accept any item and provides a mapping between OpenXml element types and model element types for proper data loading and synchronization within the document model.
/// </summary>
public class RangeItemsCollections: ContentItemsCollection
{
  /// <summary>
  /// Default constructor needed for XML serialization. Initializes a new instance of the RangeItemsCollections class.
  /// </summary>
  public RangeItemsCollections()
  {
    SetHasDirectAccess(true);
  }

  /// <summary>
  /// Initializes a new instance of the RangeItemsCollections  class with the specified parent model element and Open XML
  /// composite element as the data source.
  /// </summary>
  /// <param name="parent">The parent ModelElement that owns this collection. Cannot be null.</param>
  /// <param name="sourceElement">The model element that serves as the data source for the collection. Can be null.</param>
  public RangeItemsCollections
    (DMW.Range parent, ModelElement? sourceElement): base(parent,
    sourceElement?.GetUpdatableObject() as DX.OpenXmlCompositeElement)
  {
    SetHasDirectAccess(true);
  }

  /// <summary>
  /// Parent Range.
  /// </summary>
  public Range Range => (Parent as Range)!;


  /// <summary>
  /// Gets an enumerator that iterates through the collection, yielding each item in the collection. This method overrides the base implementation to provide direct enumeration of the items in the collection, converting them from the source collection as needed.
  /// </summary>
  /// <returns></returns>
  public override IEnumerator<ModelElement> GetEnumerator()
  {
    return EnumerateDirectly().GetEnumerator();
  }

  /// <summary>
  /// Gets the source elements for the collection, yielding each element in the range from the start to the end.
  /// </summary>
  protected override IEnumerable<DX.OpenXmlElement> GetSourceElements()
  {
    var startObject = Range.Start.GetUpdatableObject();
    var startElement = startObject as DX.OpenXmlElement;
    if (startElement is null)
      throw new ApplicationException("Can't get source elements because the start element is null.");
    var endElement = Range.End.GetUpdatableObject()! as DX.OpenXmlElement;
    var element = startElement;
    int elementIndex = 0;
    do
    {
      if (element is null)
        throw new ApplicationException("Can't get source elements because the current element is null.");

      //var str = $"Yielding element[{elementIndex++}]: {element.GetType().Name}";
      //if (element.GetType().Name == "Paragraph")
      //  str += " " + element.GetAttribute("paraId", "http://schemas.microsoft.com/office/word/2010/wordml").Value;
      //Debug.WriteLine(str);
      yield return element;
      if (element == endElement)
        break;
      element = element.NextSibling();
    } while (element != null);
  }
}
