namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single table row, which contains the table’s cells. Table rows in WordprocessingML are analogous to HTML tr elements.
/// </summary>
public partial class TableRow: ModelElement<DXW.TableRow>
{
  public TableRow(): base(){ }
  
  public TableRow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableRow(DXW.TableRow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Glyph Formatting
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowMarkRevision
  {
    get
    {
      if (_Element?.RsidTableRowMarkRevision?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidTableRowMarkRevision.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidTableRowMarkRevision = value.ToString();
      else
        _ExistingElement.RsidTableRowMarkRevision = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowAddition
  {
    get
    {
      if (_Element?.RsidTableRowAddition?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidTableRowAddition.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidTableRowAddition = value.ToString();
      else
        _ExistingElement.RsidTableRowAddition = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Deletion
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowDeletion
  {
    get
    {
      if (_Element?.RsidTableRowDeletion?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidTableRowDeletion.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidTableRowDeletion = value.ToString();
      else
        _ExistingElement.RsidTableRowDeletion = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Table Row Properties
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidTableRowProperties
  {
    get
    {
      if (_Element?.RsidTableRowProperties?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidTableRowProperties.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidTableRowProperties = value.ToString();
      else
        _ExistingElement.RsidTableRowProperties = null;
    }
  }
  
  
  /// <summary>
  ///   paraId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? ParagraphId
  {
    get
    {
      if (_Element?.ParagraphId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.ParagraphId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.ParagraphId = value.ToString();
      else
        _ExistingElement.ParagraphId = null;
    }
  }
  
  
  /// <summary>
  ///   textId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? TextId
  {
    get
    {
      if (_Element?.TextId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.TextId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.TextId = value.ToString();
      else
        _ExistingElement.TextId = null;
    }
  }
  
  
  /// <summary>
  ///   Table-Level Property Exceptions.
  /// </summary>
  [DataMember]
  public DMW.TablePropertyExceptions? TablePropertyExceptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TablePropertyExceptions>();
      if (element != null)
        return TablePropertyExceptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TablePropertyExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TablePropertyExceptionsConverter.CreateOpenXmlElement<DXW.TablePropertyExceptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Table Row Properties.
  /// </summary>
  [DataMember]
  public DMW.TableRowProperties? TableRowProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableRowProperties>();
      if (element != null)
        return TableRowPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableRowProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableRowPropertiesConverter.CreateOpenXmlElement<DXW.TableRowProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
