namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public partial class ApplicationNonVisualDrawingProperties: ModelElement<DXO10DCD.ApplicationNonVisualDrawingProperties>
{
  public ApplicationNonVisualDrawingProperties(): base(){ }
  
  public ApplicationNonVisualDrawingProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ApplicationNonVisualDrawingProperties(DXO10DCD.ApplicationNonVisualDrawingProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   macro, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Macro
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Macro);
    }
    set
    {
      _ExistingElement.Macro = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get
    {
      return _Element?.Published?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Published = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Published = null;
    }
  }
  
}
