namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of table properties which shall be applied to the contents of this row in place of the table properties specified in the tblPr element.
/// </summary>
public partial class TablePropertyExceptions: ModelElement<DXW.TablePropertyExceptions>
{
  public TablePropertyExceptions(): base(){ }
  
  public TablePropertyExceptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TablePropertyExceptions(DXW.TablePropertyExceptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Preferred Table Width Exception.
  /// </summary>
  [DataMember]
  public DMW.TableWidth? TableWidth
  {
    get
    {
      return _Element?.GetObject<DMW.TableWidth,DXW.TableWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableWidth,DXW.TableWidth>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Alignment Exception.
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
  ///   Table Cell Spacing Exception.
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
  ///   Table Indent from Leading Margin Exception.
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
  ///   Table Borders Exceptions.
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
  ///   Table Shading Exception.
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
  ///   Table Layout Exception.
  /// </summary>
  [DataMember]
  public DMW.TableLayout? TableLayout
  {
    get
    {
      return _Element?.GetObject<DMW.TableLayout,DXW.TableLayout>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableLayout,DXW.TableLayout>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Cell Margin Exceptions.
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
  
  
  /// <summary>
  ///   Table Style Conditional Formatting Settings Exception.
  /// </summary>
  [DataMember]
  public DMW.TableLook? TableLook
  {
    get
    {
      return _Element?.GetObject<DMW.TableLook,DXW.TableLook>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableLook,DXW.TableLook>(value);
    }
  }
  
  
  /// <summary>
  ///   Revision Information for Table-Level Property Exceptions.
  /// </summary>
  [DataMember]
  public DMW.TablePropertyExceptionsChange? TablePropertyExceptionsChange
  {
    get
    {
      return _Element?.GetObject<DMW.TablePropertyExceptionsChange,DXW.TablePropertyExceptionsChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TablePropertyExceptionsChange,DXW.TablePropertyExceptionsChange>(value);
    }
  }
  
}
