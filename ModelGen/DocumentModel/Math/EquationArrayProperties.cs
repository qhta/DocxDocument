namespace DocumentModel.Math;


/// <summary>
///   Equation Array Properties.
/// </summary>
public partial class EquationArrayProperties: ModelElement<DXM.EquationArrayProperties>
{
  public EquationArrayProperties(): base(){ }
  
  public EquationArrayProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EquationArrayProperties(DXM.EquationArrayProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Equation Array Base Justification.
  /// </summary>
  [DataMember]
  public DMM.VerticalAlignmentKind? BaseJustification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(_ExistingElement.GetFirstChild<DXM.BaseJustification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.BaseJustification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>(itemElement, (DMM.VerticalAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.BaseJustification, DocumentFormat.OpenXml.Math.VerticalAlignmentValues, DMM.VerticalAlignmentKind>((DMM.VerticalAlignmentKind)value));
    }
  }
  
  
  /// <summary>
  ///   Maximum Distribution.
  /// </summary>
  [DataMember]
  public DMM.MaxDistribution? MaxDistribution
  {
    get
    {
      return _Element?.GetObject<DMM.MaxDistribution,DXM.MaxDistribution>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.MaxDistribution,DXM.MaxDistribution>(value);
    }
  }
  
  
  /// <summary>
  ///   Object Distribution.
  /// </summary>
  [DataMember]
  public DMM.ObjectDistribution? ObjectDistribution
  {
    get
    {
      return _Element?.GetObject<DMM.ObjectDistribution,DXM.ObjectDistribution>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ObjectDistribution,DXM.ObjectDistribution>(value);
    }
  }
  
  
  /// <summary>
  ///   Row Spacing Rule.
  /// </summary>
  [DataMember]
  public DMM.RowSpacingRule? RowSpacingRule
  {
    get
    {
      return _Element?.GetObject<DMM.RowSpacingRule,DXM.RowSpacingRule>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.RowSpacingRule,DXM.RowSpacingRule>(value);
    }
  }
  
  
  /// <summary>
  ///   Row Spacing (Equation Array).
  /// </summary>
  [DataMember]
  public DMM.RowSpacing? RowSpacing
  {
    get
    {
      return _Element?.GetObject<DMM.RowSpacing,DXM.RowSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.RowSpacing,DXM.RowSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  [DataMember]
  public DMM.ControlProperties? ControlProperties
  {
    get
    {
      return _Element?.GetObject<DMM.ControlProperties,DXM.ControlProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ControlProperties,DXM.ControlProperties>(value);
    }
  }
  
}
