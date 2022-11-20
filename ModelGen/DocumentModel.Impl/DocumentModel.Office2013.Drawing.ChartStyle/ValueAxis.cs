namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the ValueAxis Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ITextBodyProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ITextCharacterPropertiesType))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IFontReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ILineReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IFillReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.IEffectReference))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.ChartStyle.ILineWidthScale))]
public class ValueAxis: IValueAxis
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<string>? Modifiers
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ILineReference? LineReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  public ILineWidthScale? LineWidthScale
  {
    get;
    set;
  }
  
  /// <summary>
  /// FillReference.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IFillReference? FillReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IEffectReference? EffectReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// FontReference.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IFontReference? FontReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IShapeProperties? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITextCharacterPropertiesType? TextCharacterPropertiesType
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.ITextBodyProperties? TextBodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Drawing.ChartStyle.IOfficeArtExtensionList? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
