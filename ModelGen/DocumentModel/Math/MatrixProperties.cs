namespace DocumentModel.Math;


/// <summary>
///   Matrix Properties.
/// </summary>
public partial class MatrixProperties: ModelElement<DXM.MatrixProperties>
{
  public MatrixProperties(): base(){ }
  
  public MatrixProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixProperties(DXM.MatrixProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Base Justification.
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
  ///   Hide Placeholders (Matrix).
  /// </summary>
  [DataMember]
  public DMM.HidePlaceholder? HidePlaceholder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.HidePlaceholder>();
      if (element != null)
        return HidePlaceholderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.HidePlaceholder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HidePlaceholderConverter.CreateOpenXmlElement<DXM.HidePlaceholder>(value);
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
  ///   Matrix Column Gap Rule.
  /// </summary>
  [DataMember]
  public DMM.ColumnGapRule? ColumnGapRule
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ColumnGapRule>();
      if (element != null)
        return ColumnGapRuleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ColumnGapRule>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnGapRuleConverter.CreateOpenXmlElement<DXM.ColumnGapRule>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Row Spacing (Matrix).
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
  ///   Matrix Column Spacing.
  /// </summary>
  [DataMember]
  public DMM.ColumnSpacing? ColumnSpacing
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ColumnSpacing>();
      if (element != null)
        return ColumnSpacingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ColumnSpacing>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnSpacingConverter.CreateOpenXmlElement<DXM.ColumnSpacing>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Matrix Column Gap.
  /// </summary>
  [DataMember]
  public DMM.ColumnGap? ColumnGap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.ColumnGap>();
      if (element != null)
        return ColumnGapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.ColumnGap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColumnGapConverter.CreateOpenXmlElement<DXM.ColumnGap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Matrix Columns.
  /// </summary>
  [DataMember]
  public DMM.MatrixColumns? MatrixColumns
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.MatrixColumns>();
      if (element != null)
        return MatrixColumnsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.MatrixColumns>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixColumnsConverter.CreateOpenXmlElement<DXM.MatrixColumns>(value);
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
