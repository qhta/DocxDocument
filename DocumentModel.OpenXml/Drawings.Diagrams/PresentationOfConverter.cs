using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentModel.Drawings.Diagrams;
using PresentationOf = DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf;

namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
///   Presentation Of.
/// </summary>
public static class PresentationOfConverter
{
  /// <summary>
  ///   Axis
  /// </summary>
  public static ListOf<AxisKind>? GetAxis(PresentationOf? openXmlElement)
  {
    return ListValueConverter.GetValue<AxisValues, AxisKind>(openXmlElement?.Axis);
  }

  public static void SetAxis(PresentationOf? openXmlElement, ListOf<AxisKind>? value)
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
  public static ListOf<ElementKind>? GetPointType(PresentationOf? openXmlElement)
  {
    return ListValueConverter.GetValue<ElementValues, ElementKind>(openXmlElement?.PointType);
  }

  public static void SetPointType(PresentationOf? openXmlElement, ListOf<ElementKind>? value)
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
  public static ListOf<Boolean>? GetHideLastTrans(PresentationOf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.HideLastTrans);
  }

  public static void SetHideLastTrans(PresentationOf? openXmlElement, ListOf<Boolean>? value)
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
  public static ListOf<Int32>? GetStart(PresentationOf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Start);
  }

  public static void SetStart(PresentationOf? openXmlElement, ListOf<Int32>? value)
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
  public static ListOf<UInt32>? GetCount(PresentationOf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Count);
  }

  public static void SetCount(PresentationOf? openXmlElement, ListOf<UInt32>? value)
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
  public static ListOf<Int32>? GetStep(PresentationOf? openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Step);
  }

  public static void SetStep(PresentationOf? openXmlElement, ListOf<Int32>? value)
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
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.Diagrams.ExtensionList? GetExtensionList(PresentationOf? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(PresentationOf? openXmlElement, DocumentModel.Drawings.Diagrams.ExtensionList? value)
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

  public static DocumentModel.Drawings.Diagrams.PresentationOf? CreateModelElement(PresentationOf? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Diagrams.PresentationOf();
      value.Axis = GetAxis(openXmlElement);
      value.PointType = GetPointType(openXmlElement);
      value.HideLastTrans = GetHideLastTrans(openXmlElement);
      value.Start = GetStart(openXmlElement);
      value.Count = GetCount(openXmlElement);
      value.Step = GetStep(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Diagrams.PresentationOf? value)
    where OpenXmlElementType : PresentationOf, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxis(openXmlElement, value?.Axis);
      SetPointType(openXmlElement, value?.PointType);
      SetHideLastTrans(openXmlElement, value?.HideLastTrans);
      SetStart(openXmlElement, value?.Start);
      SetCount(openXmlElement, value?.Count);
      SetStep(openXmlElement, value?.Step);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}