namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies information about the current table with regard to floating tables. Floating tables are tables in a document which are not part of the main text flow in the document and are instead absolutely positioned with a specific size and position relative to non-frame content in the current document.
/// </summary>
public partial class TablePositionProperties: ModelElement<DXW.TablePositionProperties>
{
  public TablePositionProperties(): base(){ }
  
  public TablePositionProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TablePositionProperties(DXW.TablePositionProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Distance From Left of Table to Text
  /// </summary>
  [DataMember]
  public Int16? LeftFromText
  {
    get
    {
      return _Element?.LeftFromText?.Value;
    }
    set
    {
      _ExistingElement.LeftFromText = value;
    }
  }
  
  
  /// <summary>
  ///   (Distance From Right of Table to Text
  /// </summary>
  [DataMember]
  public Int16? RightFromText
  {
    get
    {
      return _Element?.RightFromText?.Value;
    }
    set
    {
      _ExistingElement.RightFromText = value;
    }
  }
  
  
  /// <summary>
  ///   Distance From Top of Table to Text
  /// </summary>
  [DataMember]
  public Int16? TopFromText
  {
    get
    {
      return _Element?.TopFromText?.Value;
    }
    set
    {
      _ExistingElement.TopFromText = value;
    }
  }
  
  
  /// <summary>
  ///   Distance From Bottom of Table to Text
  /// </summary>
  [DataMember]
  public Int16? BottomFromText
  {
    get
    {
      return _Element?.BottomFromText?.Value;
    }
    set
    {
      _ExistingElement.BottomFromText = value;
    }
  }
  
  
  /// <summary>
  ///   Absolute Horizontal Distance From Anchor
  /// </summary>
  [DataMember]
  public Int32? TablePositionX
  {
    get
    {
      return _Element?.TablePositionX?.Value;
    }
    set
    {
      _ExistingElement.TablePositionX = value;
    }
  }
  
  
  /// <summary>
  ///   Absolute Vertical Distance From Anchor
  /// </summary>
  [DataMember]
  public Int32? TablePositionY
  {
    get
    {
      return _Element?.TablePositionY?.Value;
    }
    set
    {
      _ExistingElement.TablePositionY = value;
    }
  }
  
}
