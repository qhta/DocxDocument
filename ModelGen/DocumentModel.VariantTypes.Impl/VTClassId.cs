using System.Xml;
using System;
using DocumentFormat.OpenXml;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Class ID variant implementation. Value is of Guid type. Format is "{xxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx}.
/// </summary>
public class VTClassIdImpl: VariantImpl, VTClassId
{
  public new DocumentFormat.OpenXml.VariantTypes.VTClassId? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.VariantTypes.VTClassId?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }

  public VTClassIdImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTClassId();
  }

  public VTClassIdImpl(DocumentFormat.OpenXml.VariantTypes.VTClassId element)
  {
    OpenXmlElement = element;
  }

  public override object? Value
  {
    get
    {
      if (OpenXmlElement != null)
        return OpenXmlElement.InnerText;
      else
        return _value;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value is string str)
          OpenXmlElement.Text = str;
        if (value is null)
          OpenXmlElement.Text = string.Empty;
        else if (value is Guid gv)
          OpenXmlElement.Text = gv.ToString("B");
        else if (value is byte[] bytes)
          OpenXmlElement.Text = new Guid(bytes).ToString("B");
        else if (value is VTClassId classId)
          OpenXmlElement.Text = Guid.Parse(classId.ToString() ?? "").ToString("B");
        else
          throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTClassId");
      }
      if (value is null)
        _value = null;
      else if (value is Guid val)
        _value = val;
      else if (value is string str)
        _value = Guid.Parse(str);
      else if (value is byte[] bytes)
        _value = new Guid(bytes);
      else if (value is VTClassId classId)
        _value = Guid.Parse(classId.ToString() ?? "");
      else
        throw new InvalidOperationException($"Can't set value of {value.GetType()} type to VTClassId");
    }
  }
  private Guid? _value;

  public override TypeCode GetTypeCode()
  {
    return TypeCode.String;
  }

  public override bool ToBoolean(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Boolean");
  }

  public override byte ToByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Byte");
  }

  public override char ToChar(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Char");
  }

  public override DateTime ToDateTime(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to DateTime");
  }

  public override decimal ToDecimal(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Decimal");
  }

  public override double ToDouble(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Double");
  }

  public override short ToInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Int16");
  }

  public override int ToInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Int32");
  }

  public override long ToInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Int64");
  }

  public override sbyte ToSByte(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to SByte");
  }

  public override float ToSingle(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to Single");
  }

  public override string ToString(IFormatProvider? provider)
  {
    return (Value is Guid val) ? val.ToString("B") : string.Empty;
  }

  public override ushort ToUInt16(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to UInt16");
  }

  public override uint ToUInt32(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to UInt32");
  }

  public override ulong ToUInt64(IFormatProvider? provider)
  {
    throw new InvalidOperationException("Can't convert ClassId variant to UInt64");
  }

}
