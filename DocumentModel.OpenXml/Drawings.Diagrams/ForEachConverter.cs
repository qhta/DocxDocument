using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Algorithm = DocumentModel.Drawings.Diagrams.Algorithm;
using Choose = DocumentModel.Drawings.Diagrams.Choose;
using Constraints = DocumentModel.Drawings.Diagrams.Constraints;
using ForEach = DocumentFormat.OpenXml.Drawing.Diagrams.ForEach;
using LayoutNode = DocumentModel.Drawings.Diagrams.LayoutNode;
using PresentationOf = DocumentModel.Drawings.Diagrams.PresentationOf;
using RuleList = DocumentModel.Drawings.Diagrams.RuleList;
using Shape = DocumentModel.Drawings.Diagrams.Shape;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   For Each.
/// </summary>
public static class ForEachConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(ForEach? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(ForEach? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Reference
  /// </summary>
  public static String? GetReference(ForEach? openXmlElement)
  {
    return openXmlElement?.Reference?.Value;
  }

  public static void SetReference(ForEach? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Reference = new StringValue { Value = value };
      else
        openXmlElement.Reference = null;
  }

  /// <summary>
  ///   Axis
  /// </summary>
  public static ListOf<AxisKind>? GetAxis(ForEach? openXmlElement)
  {
    return ListValueConverter.GetValue<AxisValues, AxisKind>(openXmlElement?.Axis);
  }

  public static void SetAxis(ForEach? openXmlElement, ListOf<AxisKind>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Axis = ListValueConverter.CreateListValue<AxisValues, AxisKind>(value);
      else
        openXmlElement.Axis = null;
    }
  }

  /// <summary>
  ///   Data Point Type
  /// </summary>
  public static ListOf<ElementKind>? GetPointType(ForEach? openXmlElement)
  {
    return ListValueConverter.GetValue<ElementValues, ElementKind>(openXmlElement?.PointType);
  }

  public static void SetPointType(ForEach? openXmlElement, ListOf<ElementKind>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.PointType = ListValueConverter.CreateListValue<ElementValues, ElementKind>(value);
      else
        openXmlElement.PointType = null;
    }
  }

  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  public static ListOf<Boolean>? GetHideLastTrans(ForEach? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }

  public static void SetHideLastTrans(ForEach? openXmlElement, ListOf<Boolean>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.HideLastTrans = ListValueConverter.CreateListValue<BooleanValue>(value);
      else
        openXmlElement.HideLastTrans = null;
    }
  }

  /// <summary>
  ///   Start
  /// </summary>
  public static ListOf<Int32>? GetStart(ForEach? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }

  public static void SetStart(ForEach? openXmlElement, ListOf<Int32>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Start = ListValueConverter.CreateListValue<Int32Value>(value);
      else
        openXmlElement.Start = null;
    }
  }

  /// <summary>
  ///   Count
  /// </summary>
  public static ListOf<UInt32>? GetCount(ForEach? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }

  public static void SetCount(ForEach? openXmlElement, ListOf<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Count = ListValueConverter.CreateListValue<UInt32Value>(value);
      else
        openXmlElement.Count = null;
    }
  }

  /// <summary>
  ///   Step
  /// </summary>
  public static ListOf<Int32>? GetStep(ForEach? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }

  public static void SetStep(ForEach? openXmlElement, ListOf<Int32>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Step = ListValueConverter.CreateListValue<Int32Value>(value);
      else
        openXmlElement.Step = null;
    }
  }

  public static Algorithm? GetAlgorithm(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlgorithm(ForEach? openXmlElement, Algorithm? value)
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

  public static Shape? GetShape(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(ForEach? openXmlElement, Shape? value)
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

  public static PresentationOf? GetPresentationOf(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresentationOf(ForEach? openXmlElement, PresentationOf? value)
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

  public static Constraints? GetConstraints(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConstraints(ForEach? openXmlElement, Constraints? value)
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

  public static RuleList? GetRuleList(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return RuleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRuleList(ForEach? openXmlElement, RuleList? value)
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

  public static DocumentModel.Drawings.Diagrams.ForEach? GetChildForEach(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ForEach>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildForEach(ForEach? openXmlElement, DocumentModel.Drawings.Diagrams.ForEach? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ForEach>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<ForEach>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LayoutNode? GetLayoutNode(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayoutNode(ForEach? openXmlElement, LayoutNode? value)
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

  public static Choose? GetChoose(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return ChooseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChoose(ForEach? openXmlElement, Choose? value)
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

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(ForEach? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ForEach? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.ForEach? CreateModelElement(ForEach? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.ForEach();
      value.Name = GetName(openXmlElement);
      value.Reference = GetReference(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.Algorithm = GetAlgorithm(openXmlElement);
      value.Shape = GetShape(openXmlElement);
      value.PresentationOf = GetPresentationOf(openXmlElement);
      value.Constraints = GetConstraints(openXmlElement);
      value.RuleList = GetRuleList(openXmlElement);
      value.ChildForEach = GetChildForEach(openXmlElement);
      value.LayoutNode = GetLayoutNode(openXmlElement);
      value.Choose = GetChoose(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.ForEach? value)
    where OpenXmlElementType : ForEach, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetReference(openXmlElement, value?.Reference);
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetAlgorithm(openXmlElement, value?.Algorithm);
      SetShape(openXmlElement, value?.Shape);
      SetPresentationOf(openXmlElement, value?.PresentationOf);
      SetConstraints(openXmlElement, value?.Constraints);
      SetRuleList(openXmlElement, value?.RuleList);
      SetChildForEach(openXmlElement, value?.ChildForEach);
      SetLayoutNode(openXmlElement, value?.LayoutNode);
      SetChoose(openXmlElement, value?.Choose);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}