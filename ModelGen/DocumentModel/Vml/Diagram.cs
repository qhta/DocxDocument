namespace DocumentModel.Vml;


/// <summary>
///   VML Diagram.
/// </summary>
public partial class Diagram: ModelElement<DXVO.Diagram>
{
  public Diagram(): base(){ }
  
  public Diagram(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Diagram(DXVO.Diagram openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Diagram Style Options
  /// </summary>
  [DataMember]
  public Int64? Style
  {
    get
    {
      return _Element?.Style?.Value;
    }
    set
    {
      _ExistingElement.Style = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Automatic Format
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AutoFormat
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? Reverse
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AutoLayout
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Layout X Scale
  /// </summary>
  [DataMember]
  public Int64? ScaleX
  {
    get
    {
      return _Element?.ScaleX?.Value;
    }
    set
    {
      _ExistingElement.ScaleX = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Layout Y Scale
  /// </summary>
  [DataMember]
  public Int64? ScaleY
  {
    get
    {
      return _Element?.ScaleY?.Value;
    }
    set
    {
      _ExistingElement.ScaleY = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Font Size
  /// </summary>
  [DataMember]
  public Int64? FontSize
  {
    get
    {
      return _Element?.FontSize?.Value;
    }
    set
    {
      _ExistingElement.FontSize = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Layout Extents
  /// </summary>
  [DataMember]
  public String? ConstrainBounds
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ConstrainBounds);
    }
    set
    {
      _ExistingElement.ConstrainBounds = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  [DataMember]
  public Int64? BaseTextScale
  {
    get
    {
      return _Element?.BaseTextScale?.Value;
    }
    set
    {
      _ExistingElement.BaseTextScale = value;
    }
  }
  
  
  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  [DataMember]
  public DMVML.RelationTable? RelationTable
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.RelationTable>();
      if (element != null)
        return RelationTableConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.RelationTable>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RelationTableConverter.CreateOpenXmlElement<DXVO.RelationTable>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
