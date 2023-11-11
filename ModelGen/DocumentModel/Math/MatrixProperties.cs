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
      return _Element?.GetObject<DMM.HidePlaceholder,DXM.HidePlaceholder>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.HidePlaceholder,DXM.HidePlaceholder>(value);
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
  ///   Matrix Column Gap Rule.
  /// </summary>
  [DataMember]
  public DMM.ColumnGapRule? ColumnGapRule
  {
    get
    {
      return _Element?.GetObject<DMM.ColumnGapRule,DXM.ColumnGapRule>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ColumnGapRule,DXM.ColumnGapRule>(value);
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
      return _Element?.GetObject<DMM.RowSpacing,DXM.RowSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.RowSpacing,DXM.RowSpacing>(value);
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
      return _Element?.GetObject<DMM.ColumnSpacing,DXM.ColumnSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ColumnSpacing,DXM.ColumnSpacing>(value);
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
      return _Element?.GetObject<DMM.ColumnGap,DXM.ColumnGap>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.ColumnGap,DXM.ColumnGap>(value);
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
      return _Element?.GetObject<DMM.MatrixColumns,DXM.MatrixColumns>();
    }
    set
    {
      _ExistingElement.SetObject<DMM.MatrixColumns,DXM.MatrixColumns>(value);
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
