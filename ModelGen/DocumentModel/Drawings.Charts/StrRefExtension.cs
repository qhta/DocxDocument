namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StrRefExtension Class.
/// </summary>
public partial class StrRefExtension: ModelElement<DXDC.StrRefExtension>
{
  public StrRefExtension(): base(){ }
  
  public StrRefExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrRefExtension(DXDC.StrRefExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.FullReference? FullReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FullReference>();
      if (element != null)
        return FullReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FullReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FullReferenceConverter.CreateOpenXmlElement<DXO13DC.FullReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.LevelReference? LevelReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.LevelReference>();
      if (element != null)
        return LevelReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.LevelReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LevelReferenceConverter.CreateOpenXmlElement<DXO13DC.LevelReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC13.FormulaReference? FormulaReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.FormulaReference>();
      if (element != null)
        return FormulaReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.FormulaReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulaReferenceConverter.CreateOpenXmlElement<DXO13DC.FormulaReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
