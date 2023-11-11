namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the NumericLevel Class.
/// </summary>
public partial class NumericLevel: ModelElement<DXO16DCD.NumericLevel>
{
  public NumericLevel(): base(){ }
  
  public NumericLevel(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericLevel(DXO16DCD.NumericLevel openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? PtCount
  {
    get
    {
      return _Element?.PtCount?.Value;
    }
    set
    {
      _ExistingElement.PtCount = value;
    }
  }
  
  
  /// <summary>
  ///   formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FormatCode);
    }
    set
    {
      _ExistingElement.FormatCode = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   name, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Name
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Name);
    }
    set
    {
      _ExistingElement.Name = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DM.ElementCollection<NumericValue>? Items
  {
    get
    {
      if (_Element==null)
        return null;
      var collection = new ElementCollection<DM.NumericValue>();
      foreach (var item in _ExistingElement.Elements<DXO16DCD.NumericValue>())
      {
        var newItem = NumericValueConverter.GetValue(item);
        if (newItem is not null)
          collection.Add((NumericValue)newItem);
      }
      if (collection.Count>0)
        return collection;
      return null;
    }
    set
    {
      _ExistingElement.RemoveAllChildren<DXO16DCD.NumericValue>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = NumericValueConverter.CreateOpenXmlElement<DXO16DCD.NumericValue>(item);
          if (newItem != null)
            _ExistingElement.AddChild(newItem);
        }
      }
    }
  }
  
}
