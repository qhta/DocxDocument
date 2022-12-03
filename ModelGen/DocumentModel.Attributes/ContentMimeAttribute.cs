using System;


#nullable enable
namespace DocumentModel.Attributes
{
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface, AllowMultiple = false)]
  public sealed class ContentMimeAttribute : Attribute
  {
    public ContentMimeAttribute(string contentType) => this.ContentType = contentType;

    public string ContentType { get; }
  }
}