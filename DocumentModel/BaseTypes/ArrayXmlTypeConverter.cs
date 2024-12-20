﻿using System.ComponentModel;
using System.Xml;

using Qhta.TypeUtils;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

internal class ArrayXmlTypeConverter : VariantTypeConverter, IXmlConverter
{
  public virtual bool CanRead => true;

  public virtual bool CanWrite => true;

  public bool CanConvert(Type objectType)
  {
    return objectType == typeof(ArrayVariant);
  }

  public void WriteXml(object? context, IXmlWriter writer, object? value, IXmlSerializer? serializer)
  {
    throw new NotImplementedException();
  }

  public object? ReadXml(object? context, IXmlReader reader, Type objectType, object? existingValue, IXmlSerializer? serializer)
  {
    throw new NotImplementedException();
  }

}