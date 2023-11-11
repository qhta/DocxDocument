namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableProperties: ModelElement<DXW.StyleTableProperties>
{
  public StyleTableProperties(): base(){ }
  
  public StyleTableProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleTableProperties(DXW.StyleTableProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableStyleRowBandSize.
  /// </summary>
  [DataMember]
  public DMW.TableStyleRowBandSize? TableStyleRowBandSize
  {
    get
    {
      return _Element?.GetObject<DMW.TableStyleRowBandSize,DXW.TableStyleRowBandSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyleRowBandSize,DXW.TableStyleRowBandSize>(value);
    }
  }
  
  
  /// <summary>
  ///   TableStyleColumnBandSize.
  /// </summary>
  [DataMember]
  public DMW.TableStyleColumnBandSize? TableStyleColumnBandSize
  {
    get
    {
      return _Element?.GetObject<DMW.TableStyleColumnBandSize,DXW.TableStyleColumnBandSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableStyleColumnBandSize,DXW.TableStyleColumnBandSize>(value);
    }
  }
  
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  [DataMember]
  public DMW.TableRowAlignmentKind? TableJustification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(_ExistingElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableJustification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
    }
  }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  [DataMember]
  public DMW.TableCellSpacing? TableCellSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellSpacing,DXW.TableCellSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellSpacing,DXW.TableCellSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  [DataMember]
  public DMW.TableIndentation? TableIndentation
  {
    get
    {
      return _Element?.GetObject<DMW.TableIndentation,DXW.TableIndentation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableIndentation,DXW.TableIndentation>(value);
    }
  }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  [DataMember]
  public DMW.TableBorders? TableBorders
  {
    get
    {
      return _Element?.GetObject<DMW.TableBorders,DXW.TableBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableBorders,DXW.TableBorders>(value);
    }
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get
    {
      return _Element?.GetObject<DMW.Shading,DXW.Shading>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Shading,DXW.Shading>(value);
    }
  }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  [DataMember]
  public DMW.TableCellMarginDefault? TableCellMarginDefault
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellMarginDefault,DXW.TableCellMarginDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellMarginDefault,DXW.TableCellMarginDefault>(value);
    }
  }
  
}
