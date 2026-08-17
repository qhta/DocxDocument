using DocumentModel.Math;

using Qhta.OpenXmlTools;

namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines a region of text with a common set of properties. 
///   A run allows the producer to specify a single set of formatting properties, 
///   applying the same information to all the contents of the run. .
/// </summary>
[OpenXmlType(typeof(DXW.Run))]
[DataContract]
[XmlRoot("Run", Namespace = "DocumentModel.Wordprocessing")]
[DirectAccess(true)]
public partial class Run : ModelElement<DXW.Run>, ITextualElement,
 IParagraphContent, ISdtRunContent, IRubyContent, IBidirectionalContent, IMathArgumentContent
{
  /// <summary>
  /// Initializes a new instance of the Run class.
  /// </summary>
  public Run() : base()
  {
  }

  /// <summary>
  /// Initializes a new instance of the Run class with the specified parent object.
  /// </summary>
  /// <param name = "parent">The parent object that will contain this Run instance. This parameter establishes the hierarchical relationship
  /// within the object model and cannot be null.</param>
  /// <param name = "openXmlElement">The OpenXmlCompositeElement that provides the XML data for the Run instance. Cannot be null.</param>
  public Run(ModelElement parent, DX.OpenXmlCompositeElement? openXmlElement) : base(parent, openXmlElement)
  {
  }

  /// <summary>
  /// Initializes a new instance of the Run class using the specified OpenXmlCompositeElement.  
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlCompositeElement that provides the underlying XML data for the run.</param>
  public Run(DX.OpenXmlCompositeElement openXmlElement) : base(openXmlElement)
  {
  }

  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunProperties))]
  public HexInt? RsidProps
  {
    get => _RsidProps ??= GetProperty<HexInt?>(GetUpdatableElement()?.RsidRunProperties);
    set => UpdateField(ref _RsidProps, value, nameof(RsidProps));
  }
  private HexInt? _RsidProps;

  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunDeletion))]
  public HexInt? RsidDel
  {
    get => _RsidDel ??= GetProperty<HexInt?>(GetUpdatableElement()?.RsidRunDeletion);
    set => UpdateField(ref _RsidDel, value, nameof(RsidDel));
  }
  private HexInt? _RsidDel;

  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RsidRunAddition))]
  public HexInt? RsidAdd
  {
    get => _RsidAdd ??= GetProperty<HexInt?>(GetUpdatableElement()?.RsidRunAddition);
    set => UpdateField(ref _RsidAdd, value, nameof(RsidAdd));
  }
  private HexInt? _RsidAdd;

  /// <summary>
  ///   Specifies a set of run properties which shall be applied to the contents of the parent run 
  ///   after all style formatting has been applied to the text. These properties are defined as direct formatting, 
  ///   since they are directly applied to the run and supersede any formatting from styles..
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Run.RunProperties))]
  public RunProperties? RunProperties
  {
    get => _RunProperties ??= GetProperty<RunProperties?>(GetUpdatableElement()?.RunProperties);
    set => UpdateField(ref _RunProperties, value, nameof(RunProperties));
  }
  private RunProperties? _RunProperties;

  /// <summary>
  /// Collection of Run items, which can include text, breaks, fields, and other inline elements. 
  /// </summary>
  [XmlArray("Items")]
  [XmlArrayItem("Break", typeof(DMW.Break))]
  [XmlArrayItem("Drawing", typeof(DMW.Drawing))]
  [XmlArrayItem("NoBreakHyphen", typeof(DMW.NoBreakHyphen))]
  [XmlArrayItem("SoftHyphen", typeof(DMW.SoftHyphen))]
  [XmlArrayItem("DayShort", typeof(DMW.DayShort))]
  [XmlArrayItem("MonthShort", typeof(DMW.MonthShort))]
  [XmlArrayItem("YearShort", typeof(DMW.YearShort))]
  [XmlArrayItem("DayLong", typeof(DMW.DayLong))]
  [XmlArrayItem("MonthLong", typeof(DMW.MonthLong))]
  [XmlArrayItem("YearLong", typeof(DMW.YearLong))]
  [XmlArrayItem("AnnotationReferenceMark", typeof(DMW.AnnotationReferenceMark))]
  [XmlArrayItem("FootnoteReferenceMark", typeof(DMW.FootnoteReferenceMark))]
  [XmlArrayItem("EndnoteReferenceMark", typeof(DMW.EndnoteReferenceMark))]
  [XmlArrayItem("SeparatorMark", typeof(DMW.SeparatorMark))]
  [XmlArrayItem("ContinuationSeparatorMark", typeof(DMW.ContinuationSeparatorMark))]
  [XmlArrayItem("PageNumber", typeof(DMW.PageNumber))]
  [XmlArrayItem("CarriageReturn", typeof(DMW.CarriageReturn))]
  [XmlArrayItem("TabChar", typeof(DMW.TabChar))]
  [XmlArrayItem("LastRenderedPageBreak", typeof(DMW.LastRenderedPageBreak))]
  [XmlArrayItem("FieldChar", typeof(DMW.FieldChar))]
  [XmlArrayItem("FootnoteReference", typeof(DMW.FootnoteReference))]
  [XmlArrayItem("EndnoteReference", typeof(DMW.EndnoteReference))]
  [XmlArrayItem("CommentReference", typeof(DMW.CommentReference))]
  [XmlArrayItem("EmbeddedObject", typeof(DMW.EmbeddedObject))]
  [XmlArrayItem("Picture", typeof(DMW.Picture))]
  [XmlArrayItem("PositionalTab", typeof(DMW.PositionalTab))]
  [XmlArrayItem("RunProperties", typeof(DMW.RunProperties))]
  [XmlArrayItem("Ruby", typeof(DMW.Ruby))]
  [XmlArrayItem("SymbolChar", typeof(DMW.SymbolChar))]
  [XmlArrayItem("Text", typeof(DMW.RunText))]
  [XmlArrayItem("DeletedText", typeof(DMW.DeletedText))]
  [XmlArrayItem("FieldCode", typeof(DMW.FieldCode))]
  [XmlArrayItem("DeletedFieldCode", typeof(DMW.DeletedFieldCode))]
  public RunItemsCollection Items => _Items ??= new RunItemsCollection(this, GetUpdatableElement());
  
  private RunItemsCollection? _Items;

  /// <summary>
  /// This property provides access to the collection of text elements within the run. 
  /// </summary>
  public IEnumerable<ModelElement> TextualItems => Items.Where(item => item is ITextualElement);
  

  /// <summary>
  /// The text value represented by this element.
  /// </summary>
  [XmlText]
  public string? Text { get => GetText(); set => SetText(value); }

  /// <summary>
  /// Gets the concatenated text content of the run, combining all text elements within the run's items collection.
  /// </summary>
  /// <returns>The concatenated text content of the run.</returns>
  public string GetText()
  {
    return String.Concat(TextualItems.Select(item => (item as ITextualElement)?.Text));
  }

  /// <summary>
  /// Sets the text content of the run by updating the text of the first textual element found in the run's items collection.
  /// </summary>
  /// <param name="value">The text content to set</param>
  public void SetText(string? value)
  {
    throw new NotImplementedException("Run SetText not implemented yet");

  }

}