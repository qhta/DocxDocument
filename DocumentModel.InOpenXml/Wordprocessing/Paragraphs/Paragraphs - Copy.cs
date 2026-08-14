namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of paragraph elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "Paragraph"/> objects, enabling advanced organization and manipulation of paragraph structures within the document.
/// </summary>
public class Paragraphs : ContentItemsCollection<Paragraph>
{
  /// <summary>
  /// Default constructor for the Paragraphs class, initializing a new instance of the Paragraphs collection.
  /// </summary>
  public Paragraphs(ModelElement parent, DX.OpenXmlCompositeElement? dataSource) : base(parent, dataSource) { }


  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type> _OpenXmlElement2ModelTypeMapping = new()
  {
    { typeof(DXW.Paragraph), typeof(DMW.Paragraph) },
  };

  /// <summary>
  /// Gets the mapping between OpenXml element types and their corresponding model element types.
  /// </summary>
  protected override Dictionary<Type, Type> OpenXmlElement2ModelTypeMapping => _OpenXmlElement2ModelTypeMapping;


  /// <summary>
  /// Static mapping from OpenXml element types to model element types. 
  /// </summary>
  private static readonly Dictionary<Type, Type[]> _ModelType2OpenXmlElementsMapping = new()
  {
    { typeof(DMW.Paragraph), [typeof(DXW.Paragraph)] },
  };

  /// <summary>
  /// Gets the mapping between model element types and their corresponding OpenXml element types.
  /// </summary>
  protected override Dictionary<Type, Type[]> ModelType2OpenXmlElementsMapping => _ModelType2OpenXmlElementsMapping;
}