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
      var element = _Element?.GetFirstChild<DXM.MaxDistribution>();
      if (element != null)
        return MaxDistributionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.MaxDistribution>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MaxDistributionConverter.CreateOpenXmlElement<DXM.MaxDistribution>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.ObjectDistribution>();
      if (element != null)
        return ObjectDistributionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ObjectDistribution>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ObjectDistributionConverter.CreateOpenXmlElement<DXM.ObjectDistribution>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.RowSpacingRule>();
      if (element != null)
        return RowSpacingRuleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.RowSpacingRule>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RowSpacingRuleConverter.CreateOpenXmlElement<DXM.RowSpacingRule>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.RowSpacing>();
      if (element != null)
        return RowSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.RowSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RowSpacingConverter.CreateOpenXmlElement<DXM.RowSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXM.ControlProperties>();
      if (element != null)
        return ControlPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ControlProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
