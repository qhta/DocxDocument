namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public class CustomDocumentProperty: DocumentProperty
{
  /// <summary>
  /// Initializes a new instance of the <see cref="CustomDocumentPropertyClass"/> class.
  /// </summary>
  /// <param name="customPropertiesCollection">Collection that contains this property</param>
  /// <param name="openXmlCustomDocumentProperty">Element from the Open XML SDK representing a custom document property.</param>
  public CustomDocumentProperty(CustomProperties customPropertiesCollection, CP.CustomDocumentProperty openXmlCustomDocumentProperty)
  {
    OpenXmlCustomDocumentProperty = openXmlCustomDocumentProperty;
  }

  internal CP.CustomDocumentProperty OpenXmlCustomDocumentProperty { get; }

  /// <summary>
  ///   Property ID
  /// </summary>
  [XmlAttribute]
  public Int32? PropertyId
  {
    get => OpenXmlCustomDocumentProperty.PropertyId?.Value;
    set
    {
      if (value != OpenXmlCustomDocumentProperty.PropertyId?.Value)
      {
        OpenXmlCustomDocumentProperty.PropertyId = value;
        OnPropertyChanged(nameof(PropertyId));
      }
    }
  }

  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
  [XmlAttribute]
  public string? LinkTarget
  {
    get => OpenXmlCustomDocumentProperty.LinkTarget;
    set
    {
      if (value != OpenXmlCustomDocumentProperty.LinkTarget)
      {
        OpenXmlCustomDocumentProperty.LinkTarget = value;
        OnPropertyChanged(nameof(LinkTarget));
      }
    }
  }
}