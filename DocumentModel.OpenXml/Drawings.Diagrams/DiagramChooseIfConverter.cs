using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using Algorithm = DocumentModel.Drawings.Diagrams.Algorithm;
using Choose = DocumentModel.Drawings.Diagrams.Choose;
using Constraints = DocumentModel.Drawings.Diagrams.Constraints;
using DiagramChooseIf = DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf;
using ForEach = DocumentModel.Drawings.Diagrams.ForEach;
using LayoutNode = DocumentModel.Drawings.Diagrams.LayoutNode;
using PresentationOf = DocumentModel.Drawings.Diagrams.PresentationOf;
using RuleList = DocumentModel.Drawings.Diagrams.RuleList;
using Shape = DocumentModel.Drawings.Diagrams.Shape;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   If.
/// </summary>
public static class DiagramChooseIfConverter
{
  /// <summary>
  ///   Name
  /// </summary>
  public static String? GetName(DiagramChooseIf? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }

  public static void SetName(DiagramChooseIf? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }

  /// <summary>
  ///   Axis
  /// </summary>
  public static ListOf<AxisKind>? GetAxis(DiagramChooseIf? openXmlElement)
  {
    return ListValueConverter.GetValue<AxisValues, AxisKind>(openXmlElement?.Axis);
  }

  public static void SetAxis(DiagramChooseIf? openXmlElement, ListOf<AxisKind>? value)
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
  public static ListOf<ElementKind>? GetPointType(DiagramChooseIf? openXmlElement)
  {
    return ListValueConverter.GetValue<ElementValues, ElementKind>(openXmlElement?.PointType);
  }

  public static void SetPointType(DiagramChooseIf? openXmlElement, ListOf<ElementKind>? value)
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
  public static ListOf<Boolean>? GetHideLastTrans(DiagramChooseIf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }

  public static void SetHideLastTrans(DiagramChooseIf? openXmlElement, ListOf<Boolean>? value)
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
  public static ListOf<Int32>? GetStart(DiagramChooseIf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }

  public static void SetStart(DiagramChooseIf? openXmlElement, ListOf<Int32>? value)
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
  public static ListOf<UInt32>? GetCount(DiagramChooseIf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }

  public static void SetCount(DiagramChooseIf? openXmlElement, ListOf<UInt32>? value)
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
  public static ListOf<Int32>? GetStep(DiagramChooseIf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }

  public static void SetStep(DiagramChooseIf? openXmlElement, ListOf<Int32>? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.Step = ListValueConverter.CreateListValue<Int32Value>(value);
      else
        openXmlElement.Step = null;
    }
  }

  /// <summary>
  ///   Function
  /// </summary>
  public static FunctionKind? GetFunction(DiagramChooseIf? openXmlElement)
  {
    return EnumValueConverter.GetValue<FunctionValues, FunctionKind>(openXmlElement?.Function?.Value);
  }

  public static void SetFunction(DiagramChooseIf? openXmlElement, FunctionKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Function = EnumValueConverter.CreateEnumValue<FunctionValues, FunctionKind>(value);
  }

  /// <summary>
  ///   Argument
  /// </summary>
  public static String? GetArgument(DiagramChooseIf? openXmlElement)
  {
    return openXmlElement?.Argument?.Value;
  }

  public static void SetArgument(DiagramChooseIf? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Argument = new StringValue { Value = value };
      else
        openXmlElement.Argument = null;
  }

  /// <summary>
  ///   Operator
  /// </summary>
  public static FunctionOperatorKind? GetOperator(DiagramChooseIf? openXmlElement)
  {
    return EnumValueConverter.GetValue<FunctionOperatorValues, FunctionOperatorKind>(openXmlElement?.Operator?.Value);
  }

  public static void SetOperator(DiagramChooseIf? openXmlElement, FunctionOperatorKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Operator = EnumValueConverter.CreateEnumValue<FunctionOperatorValues, FunctionOperatorKind>(value);
  }

  /// <summary>
  ///   Value
  /// </summary>
  public static String? GetVal(DiagramChooseIf? openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }

  public static void SetVal(DiagramChooseIf? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Val = new StringValue { Value = value };
      else
        openXmlElement.Val = null;
  }

  public static Algorithm? GetAlgorithm(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Algorithm>();
    if (itemElement != null)
      return AlgorithmConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAlgorithm(DiagramChooseIf? openXmlElement, Algorithm? value)
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

  public static Shape? GetShape(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Shape>();
    if (itemElement != null)
      return ShapeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShape(DiagramChooseIf? openXmlElement, Shape? value)
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

  public static PresentationOf? GetPresentationOf(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf>();
    if (itemElement != null)
      return PresentationOfConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPresentationOf(DiagramChooseIf? openXmlElement, PresentationOf? value)
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

  public static Constraints? GetConstraints(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Constraints>();
    if (itemElement != null)
      return ConstraintsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetConstraints(DiagramChooseIf? openXmlElement, Constraints? value)
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

  public static RuleList? GetRuleList(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.RuleList>();
    if (itemElement != null)
      return RuleListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRuleList(DiagramChooseIf? openXmlElement, RuleList? value)
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

  public static ForEach? GetForEach(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ForEach>();
    if (itemElement != null)
      return ForEachConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetForEach(DiagramChooseIf? openXmlElement, ForEach? value)
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

  public static LayoutNode? GetLayoutNode(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.LayoutNode>();
    if (itemElement != null)
      return LayoutNodeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayoutNode(DiagramChooseIf? openXmlElement, LayoutNode? value)
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

  public static Choose? GetChoose(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.Choose>();
    if (itemElement != null)
      return ChooseConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChoose(DiagramChooseIf? openXmlElement, Choose? value)
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

  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(DiagramChooseIf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(DiagramChooseIf? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.DiagramChooseIf? CreateModelElement(DiagramChooseIf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.DiagramChooseIf();
      value.Name = GetName(openXmlElement);
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.Function = GetFunction(openXmlElement);
      value.Argument = GetArgument(openXmlElement);
      value.Operator = GetOperator(openXmlElement);
      value.Val = GetVal(openXmlElement);
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.DiagramChooseIf? value)
    where OpenXmlElementType : DiagramChooseIf, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetFunction(openXmlElement, value?.Function);
      SetArgument(openXmlElement, value?.Argument);
      SetOperator(openXmlElement, value?.Operator);
      SetVal(openXmlElement, value?.Val);
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