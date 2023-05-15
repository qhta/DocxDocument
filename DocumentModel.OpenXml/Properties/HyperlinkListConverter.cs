using DocumentModel.Properties;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Hyperlink List.
/// </summary>
public static class HyperlinkListConverter
{
  public static VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    return VTVectorConverter.CreateModelElement(openXmlElement?.VTVector);
  }

  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }

  #region HyperlinkList model conversion
  public static HyperlinkList? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new HyperlinkList();
      var vectorVariant = GetVTVector(openXmlElement);
      if (vectorVariant != null)
      {
        int n = vectorVariant.Count;
        for (int i = 0; i < n / 6; i++)
        {
          var item = new HyperlinkInfo();
          for (var k = 0; k < 6; k++)
          {
            var varItem = vectorVariant[i*6 + k] as Variant;
            if (varItem is not null)
            {
              switch (k)
              {
                case 0:
                  item.N1 = varItem.ToInt32();
                  break;
                case 1:
                  item.N2 = varItem.ToInt32();
                  break;
                case 2:
                  item.N3 = varItem.ToInt32();
                  break;
                case 3:
                  var n4 = varItem.ToInt32();
                  var n4l = (Int16)(n4 & 0xFFFF);
                  item.Attachment = (HyperlinkAttachment)Enum.ToObject(typeof(HyperlinkAttachment), n4l);
                  var n4h = (Int16)(n4 >> 16 & 0xFFFF);
                  item.Action = (HyperlinkAction)Enum.ToObject(typeof(HyperlinkAction), n4h);
                  break;
                case 4:
                  item.Target = varItem.ToString();
                  break;
                case 5:
                  var s = varItem.ToString();
                  if (s != "")
                    item.Location = s;
                  break;
              }
            }
          }
          model.Add(item);
        }
      }
      return model;
    }
    return null;
  }

  public static DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList? CreateOpenXmlElement(HyperlinkList? model)
  {
    if (model != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkList();
      var vector = new VectorVariant(VariantType.Variant);
      foreach (var item in model)
      {
        vector.Add(new Variant(new Variant(item.N1)));
        vector.Add(new Variant(new Variant(item.N2)));
        vector.Add(new Variant(new Variant(item.N3)));
        var n4l = (UInt16)(item.Attachment);
        var n4h = (UInt16)(item.Action);
        var n4 = (Int32)((Int32)n4h<<16 | n4l);
        vector.Add(new Variant(new Variant(n4)));
        vector.Add(new Variant(new Variant(VariantType.Lpwstr, item.Target)));
        vector.Add(new Variant(new Variant(VariantType.Lpwstr, item.Location ?? "")));
      }
      SetVTVector(openXmlElement, vector);
      return openXmlElement;
    }
    return null;
  }
  #endregion
}