namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
public class BoxPropertiesImpl: ModelElementImpl, BoxProperties
{
  public DocumentFormat.OpenXml.Math.BoxProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.BoxProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BoxPropertiesImpl(): base() {}
  
  public BoxPropertiesImpl(DocumentFormat.OpenXml.Math.BoxProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  public DocumentModel.Math.BooleanKind? OperatorEmulator
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.OperatorEmulator?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.OperatorEmulator != null)
        {
          if (value is not null)
            OpenXmlElement.OperatorEmulator.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.OperatorEmulator = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.OperatorEmulator = new DocumentFormat.OpenXml.Math.OperatorEmulator{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// No Break.
  /// </summary>
  public DocumentModel.Math.BooleanKind? NoBreak
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.NoBreak?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NoBreak != null)
        {
          if (value is not null)
            OpenXmlElement.NoBreak.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.NoBreak = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NoBreak = new DocumentFormat.OpenXml.Math.NoBreak{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Differential.
  /// </summary>
  public DocumentModel.Math.BooleanKind? Differential
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.Differential?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Differential != null)
        {
          if (value is not null)
            OpenXmlElement.Differential.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.Differential = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Differential = new DocumentFormat.OpenXml.Math.Differential{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// Break.
  /// </summary>
  public DocumentModel.Math.Break? Break
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
        if (item != null)
          return new DocumentModel.Math.BreakImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Break>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.BreakImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public DocumentModel.Math.BooleanKind? Alignment
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.Alignment?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Alignment != null)
        {
          if (value is not null)
            OpenXmlElement.Alignment.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.Alignment = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Alignment = new DocumentFormat.OpenXml.Math.Alignment{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
