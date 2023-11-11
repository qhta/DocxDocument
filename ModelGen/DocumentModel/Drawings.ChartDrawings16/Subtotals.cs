namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Subtotals Class.
/// </summary>
public partial class Subtotals: ModelElement<DXO16DCD.Subtotals>
{
  public Subtotals(): base(){ }
  
  public Subtotals(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Subtotals(DXO16DCD.Subtotals openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DM.ElementCollection<UInt32>? Items
  {
    get
    {
      if (_Element==null)
        return null;
      var collection = new ElementCollection<DMDCD16.UInt32>();
      foreach (var item in _ExistingElement.Elements<DXO16DCD.UnsignedIntegerType>())
      {
        var newItem = DX.UInt32ValueConverter.CreateModelElement(item);
        if (newItem is not null)
          collection.Add(newItem);
      }
      if (collection.Count>0)
        return collection;
      return null;
    }
    set
    {
      _ExistingElement.RemoveAllChildren<DXO16DCD.UnsignedIntegerType>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DX.UInt32ValueConverter.CreateOpenXmlElement<DXO16DCD.UnsignedIntegerType>(item);
          if (newItem != null)
            _ExistingElement.AddChild(newItem);
        }
      }
    }
  }
  
}
