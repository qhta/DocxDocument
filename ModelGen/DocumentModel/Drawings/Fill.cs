namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the fill that is applied to the table as a whole.  The background of the table can contain a single fill that is the entire size of the table.  This can allow for gradient fills, or image fills, which span the entire size of the table.
/// </summary>
public partial class Fill: ModelElement<DXD.Fill>
{
  public Fill(): base(){ }
  
  public Fill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Fill(DXD.Fill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NoFill.
  /// </summary>
  [DataMember]
  public DMD.NoFill? NoFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.NoFill>();
      if (element != null)
        return NoFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.NoFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoFillConverter.CreateOpenXmlElement<DXD.NoFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SolidFill.
  /// </summary>
  [DataMember]
  public DMD.SolidFill? SolidFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.SolidFill>();
      if (element != null)
        return SolidFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.SolidFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SolidFillConverter.CreateOpenXmlElement<DXD.SolidFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   GradientFill.
  /// </summary>
  [DataMember]
  public DMD.GradientFill? GradientFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GradientFill>();
      if (element != null)
        return GradientFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GradientFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GradientFillConverter.CreateOpenXmlElement<DXD.GradientFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   BlipFill.
  /// </summary>
  [DataMember]
  public DMD.BlipFill? BlipFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.BlipFill>();
      if (element != null)
        return BlipFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.BlipFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlipFillConverter.CreateOpenXmlElement<DXD.BlipFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  [DataMember]
  public DMD.PatternFill? PatternFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PatternFill>();
      if (element != null)
        return PatternFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PatternFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PatternFillConverter.CreateOpenXmlElement<DXD.PatternFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Group Fill.
  /// </summary>
  [DataMember]
  public DMD.GroupFill? GroupFill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.GroupFill>();
      if (element != null)
        return GroupFillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.GroupFill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupFillConverter.CreateOpenXmlElement<DXD.GroupFill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
