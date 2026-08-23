namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a drawing object in a WordprocessingML document, such as an image, chart, or diagram, that can be
/// anchored or positioned inline with text.
/// </summary>
/// <remarks>A Drawing element can contain either an anchor or an inline drawing, but not both. Anchored drawings
/// are positioned relative to the page or paragraph and can float, while inline drawings are placed directly within the
/// text flow. This class provides access to the underlying Open XML drawing structure and allows manipulation of
/// drawing properties within a WordprocessingML document.</remarks>
[DataContract]
[XmlRoot("Drawing", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.Drawing))]
public class Drawing : ModelElement<DXW.Drawing>
{
  /// <summary>
  /// Default constructor for the Drawing class, initializing a new instance without any parent or underlying OpenXML element.
  /// </summary>
  public Drawing() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the Drawing class with the specified parent element and underlying Open XML element.
  /// </summary>
  /// <param name="parent">The parent ModelElement that will contain this Drawing instance. Cannot be null.</param>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that represents the underlying Open XML structure for this Drawing. Cannot be null.</param>
  public Drawing(ModelElement parent, DX.OpenXmlCompositeElement openXmlElement) : base(parent, openXmlElement)
  {
  }

  /// <summary>
  /// Anchor of the drawing, which determines how the drawing is positioned relative to the text. 
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Drawing.Anchor))]
  public DMWD.Anchor? Anchor
  {
    get;
    set;
  }

  /// <summary>
  /// Inline drawing, which is positioned directly in the text flow and moves with the surrounding text.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Drawing.Inline))]
  public DMWD.Inline? Inline
  {
    get;
    set;
  }
}