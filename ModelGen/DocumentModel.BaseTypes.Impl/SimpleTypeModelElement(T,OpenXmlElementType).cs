using DocumentFormat.OpenXml;

namespace DocumentModel.Impl;

public abstract class SimpleTypeModelElement<T, OpenXmlElementType>: ModelElement<OpenXmlElementType>
  where OpenXmlElementType: OpenXmlElement
{
  public T? Value { get => (T?)GetValue(); set=>SetValue(value); }

  protected abstract Object? GetValue();
  protected abstract void SetValue(object? value);
}