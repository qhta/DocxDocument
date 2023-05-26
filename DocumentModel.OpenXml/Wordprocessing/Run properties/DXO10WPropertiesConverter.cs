using DocumentModel.Drawings;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// <see cref="DocumentModel.Drawings.DrawingProperties"/> class from/to OpenXml converter.
/// </summary>
public static class DXO10WPropertiesConverter
{

  #region DrawingProperty conversion.
  public static DM.IModelElement? CreateDrawingProperty(DX.OpenXmlElement? openXmlElement)
  {
    if (openXmlElement?.LocalName == "glow")
    {
      var glow = new DXO10W.Glow(openXmlElement.OuterXml);
      return DMXW.GlowConverter.CreateModelElement(glow);
    }
    if (openXmlElement?.LocalName == "shadow")
    {
      var shadow = new DXO10W.Shadow(openXmlElement.OuterXml);
      return DMXW.ShadowConverter.CreateModelElement(shadow);
    }
    if (openXmlElement?.LocalName == "reflection")
    {
      var reflection = new DXO10W.Reflection();
      reflection.SetAttributes(openXmlElement.GetAttributes());
      return DMXW.ReflectionConverter.CreateModelElement(reflection);
    }
    if (openXmlElement?.LocalName == "textOutline")
    {
      var textOutline = new DXO10W.TextOutlineEffect(openXmlElement.OuterXml);
      return DMXW.TextOutlineEffectConverter.CreateModelElement(textOutline);
    }
    if (openXmlElement?.LocalName == "scene3d")
    {
      var scene3D = new DXO10W.Scene3D(openXmlElement.OuterXml);
      return DMXW.Scene3DConverter.CreateModelElement(scene3D);
    }
    if (openXmlElement?.LocalName == "props3d")
    {
      var props3D = new DXO10W.Properties3D(openXmlElement.OuterXml);
      return DMXW.Properties3DConverter.CreateModelElement(props3D);
    }
    if (openXmlElement?.LocalName == "ligatures")
    {
      var ligatures = new DXO10W.Ligatures();
      ligatures.SetAttributes(openXmlElement.GetAttributes());
      return null;
      //return DMXW.LigaturesConverter.CreateModelElement(ligatures);
    }
    if (openXmlElement?.LocalName == "numForm")
    {
      var numForm = new DXO10W.NumberingFormat();
      numForm.SetAttributes(openXmlElement.GetAttributes());
      return null;
      //return DMXW.NumberingFormatConverter.CreateModelElement(numForm);
    }
    if (openXmlElement?.LocalName == "numSpacing")
    {
      var numSpacing = new DXO10W.NumberSpacing();
      numSpacing.SetAttributes(openXmlElement.GetAttributes());
      return null;
      //return DMXW.NumberingFormatConverter.CreateModelElement(numForm);
    }
    if (openXmlElement?.LocalName == "stylisticSets")
    {
      var stylisticSets = new DXO10W.StylisticSets(openXmlElement.OuterXml);
      return DMXW.StylisticSetsConverter.CreateModelElement(stylisticSets);
    }
    if (openXmlElement?.LocalName == "cntxtAlts")
    {
      var cntxAlts = new DXO10W.ContextualAlternatives();
      cntxAlts.SetAttributes(openXmlElement.GetAttributes());
      return null;
      //return DMXW.ContextualAlternatives.CreateModelElement(cntxAlts);
    }
    if (openXmlElement != null)
      throw new InvalidOperationException($"Element \"{openXmlElement.GetType()}\" not recognized in Run.CreateDrawingProperty method");
    return null;
  }

  public static bool CompareDrawingProperty(DX.OpenXmlElement? openXmlElement, DMD.IDrawingProperty? model,
    DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXO10W.Glow glowElement && model is DMW.Glow glowModel)
        return DMXW.GlowConverter.CompareModelElement(glowElement, glowModel, diffs, objName, propName);
      diffs?.Add(objName, "Type", openXmlElement.GetType().Name, model.GetType().Name);
      return false;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElement CreateDrawingPropertyElement(DMD.IDrawingProperty model)
  {
    if (model is DMW.Glow glow)
      return DMXW.GlowConverter.CreateOpenXmlElement(glow);

    throw new InvalidOperationException($"Type of type \"{model.GetType()}\" not supported in Run.CreateDrawingPropertyElement method");
  }

  public static bool UpdateOpenXmlElement(DX.OpenXmlElement? openXmlElement, DMD.IDrawingProperty? model)
  {
    if (openXmlElement != null && model != null)
    {
      if (openXmlElement is DXO10W.Glow glowElement && model is DMW.Glow glowModel)
        return DMXW.GlowConverter.UpdateOpenXmlElement(glowElement, glowModel);
    }
    return false;
  }
  #endregion

  #region DrawingProperties model conversion.
  public static ElementCollection<DM.IModelElement>? GetDXO10WProperties(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var elements = openXmlElement.Elements().Where(item => item.NamespaceUri == "http://schemas.microsoft.com/office/word/2010/wordml");
      if (elements.Any())
      {
        var model = new ElementCollection<DM.IModelElement>();
        ElementCollectionConverter<DM.IModelElement>.FillModelElementCollection(
          elements, model,
          CreateDrawingProperty);
        if (model.Count > 0)
          return model;
      }
    }
    return null;
  }

  public static bool UpdateRunProperties(DMW.BaseRunProperties runProperties, DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var properties = GetDXO10WProperties(openXmlElement);
      if (properties != null)
      {
        var drawingProperties = properties.OfType<IDrawingProperty>();
        if (drawingProperties.Any())
          runProperties.DrawingProperties = new DMD.DrawingProperties(drawingProperties);
      }
    }
    return false;
  }

  //public static bool CompareModelElement(DXW.RunProperties openXmlElement, DMD.DrawingProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  //{
  //  if (openXmlElement != null && model != null)
  //  {
  //    var ok = true;
  //    if (!CompareDrawingProperty(openXmlElement, model.Glow, diffs, objName, propName))
  //      ok = false;
  //    if (!CmpRsidRunDeletion(openXmlElement, model.RsidRunDeletion, diffs, objName, propName))
  //      ok = false;
  //    if (!CmpRsidRunAddition(openXmlElement, model.RsidRunAddition, diffs, objName, propName))
  //      ok = false;
  //    if (!CmpRunProperties(openXmlElement, model.RunProperties, diffs, objName, propName))
  //      ok = false;
  //    if (!ElementCollectionConverter<IRunContent>.CompareOpenXmlElementCollection(
  //      openXmlElement.Where(item => item is not DXW.RunProperties), model,
  //      CompareRunContent, diffs, objName, propName))
  //      ok = false;
  //    return ok;
  //  }
  //  if (openXmlElement == null && model == null) return true;
  //  diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
  //  return false;
  //}

  //public static DXW.Run CreateOpenXmlElement(DMW.Run model)
  //{
  //  var openXmlElement = new DXW.Run();
  //  UpdateOpenXmlElement(openXmlElement, model);
  //  return openXmlElement;
  //}

  //public static bool UpdateOpenXmlElement(DXW.Run openXmlElement, DMW.Run model)
  //{
  //  SetRsidRunProperties(openXmlElement, model.RsidRunProperties);
  //  SetRsidRunDeletion(openXmlElement, model.RsidRunDeletion);
  //  SetRsidRunAddition(openXmlElement, model.RsidRunAddition);
  //  SetRunProperties(openXmlElement, model.RunProperties);
  //  return ElementCollectionConverter<IRunContent>.UpdateOpenXmlElementCollection(openXmlElement, model,
  //    CompareRunContent,
  //    UpdateOpenXmlElement,
  //    CreateOpenXmlElement
  //    );
  //}
  #endregion
}
