namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// For Each.
/// </summary>
public partial class ForEachImpl: ModelElementImpl, ForEach
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ForEach? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ForEach?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ForEachImpl(): base() {}
  
  public ForEachImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ForEach openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (System.String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public String? Reference
  {
    get => (System.String?)OpenXmlElement?.Reference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Reference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>? Axis
  {
    get
    {
      if (OpenXmlElement?.Axis != null)
        return new DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.AxisKind>(OpenXmlElement.Axis.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Axis = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>>(value.Items.Select(item => new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues>((DocumentFormat.OpenXml.Drawing.Diagrams.AxisValues)item)));
    else
      OpenXmlElement.Axis = null;
      }
    }
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>? PointType
  {
    get
    {
      if (OpenXmlElement?.PointType != null)
        return new DocumentModel.ListOf<DocumentModel.Drawings.Diagrams.ElementKind>(OpenXmlElement.PointType.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.PointType = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>>(value.Items.Select(item => new DocumentFormat.OpenXml.EnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues>((DocumentFormat.OpenXml.Drawing.Diagrams.ElementValues)item)));
    else
      OpenXmlElement.PointType = null;
      }
    }
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public DocumentModel.ListOf<System.Boolean>? HideLastTrans
  {
    get
    {
      if (OpenXmlElement?.HideLastTrans != null)
        return new DocumentModel.ListOf<System.Boolean>(OpenXmlElement.HideLastTrans.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.HideLastTrans = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.BooleanValue>(value.Items.Select(item => new DocumentFormat.OpenXml.BooleanValue(item)));
    else
      OpenXmlElement.HideLastTrans = null;
      }
    }
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Start
  {
    get
    {
      if (OpenXmlElement?.Start != null)
        return new DocumentModel.ListOf<System.Int32>(OpenXmlElement.Start.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Start = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.Int32Value>(value.Items.Select(item => new DocumentFormat.OpenXml.Int32Value(item)));
    else
      OpenXmlElement.Start = null;
      }
    }
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public DocumentModel.ListOf<System.UInt32>? Count
  {
    get
    {
      if (OpenXmlElement?.Count != null)
        return new DocumentModel.ListOf<System.UInt32>(OpenXmlElement.Count.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Count = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.UInt32Value>(value.Items.Select(item => new DocumentFormat.OpenXml.UInt32Value(item)));
    else
      OpenXmlElement.Count = null;
      }
    }
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public DocumentModel.ListOf<System.Int32>? Step
  {
    get
    {
      if (OpenXmlElement?.Step != null)
        return new DocumentModel.ListOf<System.Int32>(OpenXmlElement.Step.InnerText);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value?.Items.Any() == true)
          OpenXmlElement.Step = new DocumentFormat.OpenXml.ListValue<DocumentFormat.OpenXml.Int32Value>(value.Items.Select(item => new DocumentFormat.OpenXml.Int32Value(item)));
    else
      OpenXmlElement.Step = null;
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.Algorithm? Algorithm
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.AlgorithmImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.AlgorithmImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.Shape? Shape
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ShapeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ShapeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.PresentationOf? PresentationOf
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.PresentationOfImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.PresentationOfImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.Constraints? Constraints
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ConstraintsImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ConstraintsImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.RuleList? RuleList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.RuleListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.RuleListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.ForEach? ChildForEach
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ForEachImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ForEachImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.LayoutNode? LayoutNode
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.LayoutNodeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.LayoutNodeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.Choose? Choose
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ChooseImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ChooseImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
