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
    get => _Element?.Macro;
    set => _ExistingElement.Macro = value;
  }
  
  
  /// <summary>
  ///   fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Boolean? Published
  {
    get => _Element?.Published?.Value;
    set => _ExistingElement.Published = value;
  }
  
}
