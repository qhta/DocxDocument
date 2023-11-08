namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a run of content in the parent field, hyperlink, custom XML element, structured document tag, smart tag, or paragraph.
/// </summary>
public partial class Run: ModelElement<DXW.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXW.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunProperties
  {
    get
    {
      if (_Element?.RsidRunProperties?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidRunProperties.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidRunProperties = value.ToString();
      else
        _ExistingElement.RsidRunProperties = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunDeletion
  {
    get
    {
      if (_Element?.RsidRunDeletion?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidRunDeletion.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidRunDeletion = value.ToString();
      else
        _ExistingElement.RsidRunDeletion = null;
    }
  }
  
  
  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunAddition
  {
    get
    {
      if (_Element?.RsidRunAddition?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.RsidRunAddition.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.RsidRunAddition = value.ToString();
      else
        _ExistingElement.RsidRunAddition = null;
    }
  }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RunProperties>();
      if (element != null)
        return RunPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RunProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesConverter.CreateOpenXmlElement<DXW.RunProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
