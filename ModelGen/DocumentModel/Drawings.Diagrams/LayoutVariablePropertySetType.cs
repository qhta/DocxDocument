namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the LayoutVariablePropertySetType Class.
/// </summary>
public partial class LayoutVariablePropertySetType: ModelElement<DXDDD.LayoutVariablePropertySetType>
{
  public LayoutVariablePropertySetType(): base(){ }
  
  public LayoutVariablePropertySetType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutVariablePropertySetType(DXDDD.LayoutVariablePropertySetType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Show Organization Chart User Interface.
  /// </summary>
  [DataMember]
  public Boolean? OrganizationChart
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXDDD.OrganizationChart>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXDDD.OrganizationChart>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXDDD.OrganizationChart();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Maximum Children.
  /// </summary>
  [DataMember]
  public Int32? MaxNumberOfChildren
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDDD.MaxNumberOfChildren>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDDD.MaxNumberOfChildren,System.Int32>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Preferred Number of Children.
  /// </summary>
  [DataMember]
  public Int32? PreferredNumberOfChildren
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDDD.PreferredNumberOfChildren>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDDD.PreferredNumberOfChildren,System.Int32>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Show Insert Bullet.
  /// </summary>
  [DataMember]
  public Boolean? BulletEnabled
  {
    get
    {
      return _ExistingElement.GetFirstChild<DXDDD.BulletEnabled>() != null;
    }
    set
    {
      if (value == false)
      {
        var itemElement = _ExistingElement.GetFirstChild<DXDDD.BulletEnabled>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DXDDD.BulletEnabled();
        _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Diagram Direction.
  /// </summary>
  [DataMember]
  public DMDD.DirectionKind? Direction
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(_ExistingElement.GetFirstChild<DXDDD.Direction>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.Direction>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>(itemElement, (DMDD.DirectionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDDD.Direction, DocumentFormat.OpenXml.Drawing.Diagrams.DirectionValues, DMDD.DirectionKind>((DMDD.DirectionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Organization Chart Branch Style.
  /// </summary>
  [DataMember]
  public DMDD.HierarchyBranchStyleKind? HierarchyBranch
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(_ExistingElement.GetFirstChild<DXDDD.HierarchyBranch>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.HierarchyBranch>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>(itemElement, (DMDD.HierarchyBranchStyleKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDDD.HierarchyBranch, DocumentFormat.OpenXml.Drawing.Diagrams.HierarchyBranchStyleValues, DMDD.HierarchyBranchStyleKind>((DMDD.HierarchyBranchStyleKind)value));
    }
  }
  
  
  /// <summary>
  ///   One by One Animation String.
  /// </summary>
  [DataMember]
  public DMDD.AnimateOneByOneKind? AnimateOneByOne
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(_ExistingElement.GetFirstChild<DXDDD.AnimateOneByOne>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.AnimateOneByOne>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>(itemElement, (DMDD.AnimateOneByOneKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDDD.AnimateOneByOne, DocumentFormat.OpenXml.Drawing.Diagrams.AnimateOneByOneValues, DMDD.AnimateOneByOneKind>((DMDD.AnimateOneByOneKind)value));
    }
  }
  
  
  /// <summary>
  ///   Level Animation.
  /// </summary>
  [DataMember]
  public DMDD.AnimationLevelStringKind? AnimationLevel
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(_ExistingElement.GetFirstChild<DXDDD.AnimationLevel>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.AnimationLevel>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>(itemElement, (DMDD.AnimationLevelStringKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDDD.AnimationLevel, DocumentFormat.OpenXml.Drawing.Diagrams.AnimationLevelStringValues, DMDD.AnimationLevelStringKind>((DMDD.AnimationLevelStringKind)value));
    }
  }
  
  
  /// <summary>
  ///   Shape Resize Style.
  /// </summary>
  [DataMember]
  public DMDD.ResizeHandlesStringKind? ResizeHandles
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(_ExistingElement.GetFirstChild<DXDDD.ResizeHandles>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ResizeHandles>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>(itemElement, (DMDD.ResizeHandlesStringKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDDD.ResizeHandles, DocumentFormat.OpenXml.Drawing.Diagrams.ResizeHandlesStringValues, DMDD.ResizeHandlesStringKind>((DMDD.ResizeHandlesStringKind)value));
    }
  }
  
}
