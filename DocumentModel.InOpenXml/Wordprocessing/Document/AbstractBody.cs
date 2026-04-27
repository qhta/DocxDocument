namespace DocumentModel.Wordprocessing;
/// <summary>
/// Common interface for <see cref = "Body"/> and <see cref = "DocPartBody"/> elements in a WordprocessingML document.
/// This class extends <see cref = "IStory"/> and provides a property for accessing the collection of sections, which is recollected from <see cref = "ISectionProperties"/> elements, enabling advanced organization and management of document structure and section content.
/// </summary>
[OpenXmlType(typeof(DXW.BodyType))]
[XmlRoot("AbstractBody", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class AbstractBody<T> : Story<T> where T : DXW.BodyType
{
  /// <summary>
  /// Default constructor for the AbstractBody class, initializing a new instance of the AbstractBody class.
  /// </summary>
  protected AbstractBody() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the AbstractBody class with the specified parent element.
  /// </summary>
  /// <param name="parent">The parent ModelElement to associate with this body. Can be null if the body does not have a parent.</param>
  protected AbstractBody(ModelElement parent) : base(parent)
  {
  }

  /// <summary>
  /// Initializes a new instance of the AbstractBody class with the specified body type.  
  /// </summary>
  /// <param name="bodyType">The body type to associate with this instance.</param>
  protected AbstractBody(DX.OpenXmlCompositeElement bodyType) : base(bodyType)
  {
  }

  /// <summary>
  /// Collection of sections, recollected from <see cref = "ISectionProperties"/> elements within the document body.
  /// </summary>
  public Sections? Sections { get; set; }
}