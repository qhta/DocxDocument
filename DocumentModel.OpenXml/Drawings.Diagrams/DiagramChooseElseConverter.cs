using DocumentFormat.OpenXml.Drawing.Diagrams;
using Algorithm = DocumentModel.Drawings.Diagrams.Algorithm;
using Choose = DocumentModel.Drawings.Diagrams.Choose;
using Constraints = DocumentModel.Drawings.Diagrams.Constraints;
using ForEach = DocumentModel.Drawings.Diagrams.ForEach;
using LayoutNode = DocumentModel.Drawings.Diagrams.LayoutNode;
using PresentationOf = DocumentModel.Drawings.Diagrams.PresentationOf;
using RuleList = DocumentModel.Drawings.Diagrams.RuleList;
using Shape = DocumentModel.Drawings.Diagrams.Shape;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Else.
/// </summary>
public static class DiagramChooseElseConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(DiagramChooseElse? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(DiagramChooseElse? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  public static Algorithm? GetAlgorithm(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlgorithm(DiagramChooseElse? openXmlElement, Algorithm? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AlgorithmConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Shape? GetShape(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(DiagramChooseElse? openXmlElement, Shape? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static PresentationOf? GetPresentationOf(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresentationOf(DiagramChooseElse? openXmlElement, PresentationOf? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresentationOfConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Constraints? GetConstraints(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConstraints(DiagramChooseElse? openXmlElement, Constraints? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConstraintsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RuleList? GetRuleList(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return RuleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRuleList(DiagramChooseElse? openXmlElement, RuleList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RuleListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ForEach? GetForEach(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
    if (itemElement != null)
      return ForEachConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetForEach(DiagramChooseElse? openXmlElement, ForEach? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ForEachConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LayoutNode? GetLayoutNode(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayoutNode(DiagramChooseElse? openXmlElement, LayoutNode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutNodeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Choose? GetChoose(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return ChooseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChoose(DiagramChooseElse? openXmlElement, Choose? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChooseConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DiagramChooseElse? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DiagramChooseElse? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Diagrams.DiagramChooseElse? CreateModelElement(DiagramChooseElse? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramChooseElse();
      value.Name = GetName(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.ForEach = GetForEach(openXmlElement);
      value.LayoutNode = GetLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramChooseElse? value)
    where OpenXmlElementType : DiagramChooseElse, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetAlgorithm(openXmlElement, value?.Algorithm);
      SetShape(openXmlElement, value?.Shape);
      SetPresentationOf(openXmlElement, value?.PresentationOf);
      SetConstraints(openXmlElement, value?.Constraints);
      SetRuleList(openXmlElement, value?.RuleList);
      SetForEach(openXmlElement, value?.ForEach);
      SetLayoutNode(openXmlElement, value?.LayoutNode);
      SetChoose(openXmlElement, value?.Choose);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}