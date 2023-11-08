namespace DocumentModel.CustomUI10;


/// <summary>
///   Defines the MenuSeparator Class.
/// </summary>
public partial class MenuSeparator: ModelElement<DXO10CUI.MenuSeparator>
{
  public MenuSeparator(): base(){ }
  
  public MenuSeparator(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MenuSeparator(DXO10CUI.MenuSeparator openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? QualifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.QualifiedId);
    }
    set
    {
      _ExistingElement.QualifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Tag
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Tag);
    }
    set
    {
      _ExistingElement.Tag = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertAfterMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertAfterMso);
    }
    set
    {
      _ExistingElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeMso
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertBeforeMso);
    }
    set
    {
      _ExistingElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertAfterQulifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertAfterQulifiedId);
    }
    set
    {
      _ExistingElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? InsertBeforeQulifiedId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.InsertBeforeQulifiedId);
    }
    set
    {
      _ExistingElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   title, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? Title
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Title);
    }
    set
    {
      _ExistingElement.Title = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   getTitle, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? GetTitle
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetTitle);
    }
    set
    {
      _ExistingElement.GetTitle = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
