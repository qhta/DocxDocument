namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Connection.
/// </summary>
public partial class Connection: ModelElement<DXDDD.Connection>
{
  public Connection(): base(){ }
  
  public Connection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Connection(DXDDD.Connection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Model Identifier
  /// </summary>
  [DataMember]
  public String? ModelId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ModelId);
    }
    set
    {
      _ExistingElement.ModelId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Source Identifier
  /// </summary>
  [DataMember]
  public String? SourceId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SourceId);
    }
    set
    {
      _ExistingElement.SourceId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Destination Identifier
  /// </summary>
  [DataMember]
  public String? DestinationId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DestinationId);
    }
    set
    {
      _ExistingElement.DestinationId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Source Position
  /// </summary>
  [DataMember]
  public UInt32? SourcePosition
  {
    get
    {
      return _Element?.SourcePosition?.Value;
    }
    set
    {
      _ExistingElement.SourcePosition = value;
    }
  }
  
  
  /// <summary>
  ///   Destination Position
  /// </summary>
  [DataMember]
  public UInt32? DestinationPosition
  {
    get
    {
      return _Element?.DestinationPosition?.Value;
    }
    set
    {
      _ExistingElement.DestinationPosition = value;
    }
  }
  
  
  /// <summary>
  ///   Parent Transition Identifier
  /// </summary>
  [DataMember]
  public String? ParentTransitionId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ParentTransitionId);
    }
    set
    {
      _ExistingElement.ParentTransitionId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Sibling Transition Identifier
  /// </summary>
  [DataMember]
  public String? SiblingTransitionId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.SiblingTransitionId);
    }
    set
    {
      _ExistingElement.SiblingTransitionId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Presentation Identifier
  /// </summary>
  [DataMember]
  public String? PresentationId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.PresentationId);
    }
    set
    {
      _ExistingElement.PresentationId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDDD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
