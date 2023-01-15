using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Algorithm = DocumentModel.Drawings.Diagrams.Algorithm;
using Choose = DocumentModel.Drawings.Diagrams.Choose;
using Constraints = DocumentModel.Drawings.Diagrams.Constraints;
using ForEach = DocumentModel.Drawings.Diagrams.ForEach;
using LayoutNode = DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode;
using PresentationOf = DocumentModel.Drawings.Diagrams.PresentationOf;
using RuleList = DocumentModel.Drawings.Diagrams.RuleList;
using Shape = DocumentModel.Drawings.Diagrams.Shape;
using VariableList = DocumentModel.Drawings.Diagrams.VariableList;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Layout Node.
/// </summary>
public static class LayoutNodeConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(LayoutNode? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(LayoutNode? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Style Label
  /// </summary>
  public static String? GetStyleLabel(LayoutNode? openXmlElement)
  {
    return openXmlElement?.StyleLabel?.Value;
  }

  public static void SetStyleLabel(LayoutNode? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StyleLabel = new StringValue { Value = value };
      else
        openXmlElement.StyleLabel = null;
  }

  /// <summary>
  ///   Child Order
  /// </summary>
  public static ChildOrderKind? GetChildOrder(LayoutNode? openXmlElement)
  {
    return EnumValueConverter.GetValue<ChildOrderValues, ChildOrderKind>(openXmlElement?.ChildOrder?.Value);
  }

  public static void SetChildOrder(LayoutNode? openXmlElement, ChildOrderKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.ChildOrder = EnumValueConverter.CreateEnumValue<ChildOrderValues, ChildOrderKind>(value);
  }

  /// <summary>
  ///   Move With
  /// </summary>
  public static String? GetMoveWith(LayoutNode? openXmlElement)
  {
    return openXmlElement?.MoveWith?.Value;
  }

  public static void SetMoveWith(LayoutNode? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.MoveWith = new StringValue { Value = value };
      else
        openXmlElement.MoveWith = null;
  }

  public static Algorithm? GetAlgorithm(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlgorithm(LayoutNode? openXmlElement, Algorithm? value)
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

  public static Shape? GetShape(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(LayoutNode? openXmlElement, Shape? value)
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

  public static PresentationOf? GetPresentationOf(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresentationOf(LayoutNode? openXmlElement, PresentationOf? value)
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

  public static Constraints? GetConstraints(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConstraints(LayoutNode? openXmlElement, Constraints? value)
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

  public static RuleList? GetRuleList(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return RuleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRuleList(LayoutNode? openXmlElement, RuleList? value)
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

  public static VariableList? GetVariableList(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>();
    if (itemElement != null)
      return VariableListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetVariableList(LayoutNode? openXmlElement, VariableList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VariableListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Diagrams.VariableList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ForEach? GetForEach(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
    if (itemElement != null)
      return ForEachConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetForEach(LayoutNode? openXmlElement, ForEach? value)
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

  public static DocumentModel.Drawings.Diagrams.LayoutNode? GetChildLayoutNode(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LayoutNode>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildLayoutNode(LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.LayoutNode? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LayoutNode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<LayoutNode>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Choose? GetChoose(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return ChooseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChoose(LayoutNode? openXmlElement, Choose? value)
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

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(LayoutNode? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(LayoutNode? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.LayoutNode? CreateModelElement(LayoutNode? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.LayoutNode();
      value.Name = GetName(openXmlElement);
      value.StyleLabel = GetStyleLabel(openXmlElement);
      value.ChildOrder = GetChildOrder(openXmlElement);
      value.MoveWith = GetMoveWith(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.VariableList = GetVariableList(openXmlElement);
      value.ForEach = GetForEach(openXmlElement);
      value.ChildLayoutNode = GetChildLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.LayoutNode? value)
    where OpenXmlElementType : LayoutNode, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetStyleLabel(openXmlElement, value?.StyleLabel);
      SetChildOrder(openXmlElement, value?.ChildOrder);
      SetMoveWith(openXmlElement, value?.MoveWith);
      SetAlgorithm(openXmlElement, value?.Algorithm);
      SetShape(openXmlElement, value?.Shape);
      SetPresentationOf(openXmlElement, value?.PresentationOf);
      SetConstraints(openXmlElement, value?.Constraints);
      SetRuleList(openXmlElement, value?.RuleList);
      SetVariableList(openXmlElement, value?.VariableList);
      SetForEach(openXmlElement, value?.ForEach);
      SetChildLayoutNode(openXmlElement, value?.ChildLayoutNode);
      SetChoose(openXmlElement, value?.Choose);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}