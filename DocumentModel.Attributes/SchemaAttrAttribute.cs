// Decompiled with JetBrains decompiler
// Type: DocumentModel.Attributes.SchemaAttrAttribute
// Assembly: DocumentModel.Attributes, Version=2.18.0.0, Culture=neutral, PublicKeyToken=8fb06cb64d019a17
// MVID: A894C618-EA88-49A6-BB01-1ADD8EA78DE8
// Assembly location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.dll
// XML documentation location: C:\Users\qhta1\.nuget\packages\DocumentModel.Attributes\2.18.0\lib\netstandard2.0\DocumentModel.Attributes.xml




#nullable enable
using System;
using System.Runtime.InteropServices.ComTypes;
using System.Xml;

namespace DocumentModel.Attributes
{
  /// <summary>
  /// Defines the attribute which is used to decorate a property for its corresponding attribute information.
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
  //[Obsolete("This attribute is no longer used to identify schema information. It didn't contain everything and a new API will be forthcoming.")]
  public sealed class SchemaAttrAttribute : System.Attribute
  {
    private readonly XmlQualifiedName _qname;

    ///// <summary>
    ///// Initializes a new instance of the SchemaAttrAttribute.
    ///// </summary>
    ///// <param name="nsId">Specifies the namespace Id of the schema attribute.</param>
    ///// <param name="tag">Specifies the Tag name of the schema attribute.</param>
    ///// <remarks>This will be removed once the concept of id can be removed. Please use <see cref="M:DocumentModel.Attributes.SchemaAttrAttribute.#ctor(System.String,System.String)" /></remarks>
    //[Obsolete("The namespace id is no longer tracked and will be removed in future release.")]
    //public SchemaAttrAttribute(byte nsId, string tag)
    //{
    //  if (string.IsNullOrEmpty(tag))
    //    throw new ArgumentNullException(nameof (tag));
    //  IFeatureCollection typedOrDefault = FeatureCollection.TypedOrDefault;
    //  string prefix = typedOrDefault.GetRequired<IOpenXmlNamespaceIdResolver>().GetPrefix(nsId);
    //  OpenXmlNamespace ns = (OpenXmlNamespace) (typedOrDefault.GetRequired<IOpenXmlNamespaceResolver>().LookupNamespace(prefix) ?? string.Empty);
    //  this._qname = new OpenXmlQualifiedName(in ns, tag);
    //}

    /// <summary>
    /// Initializes a new instance of the SchemaAttrAttribute.
    /// </summary>
    /// <param name="qname">Qualified name of item.</param>
    /// <remarks>This will be removed once the concept of id can be removed. Please use <see cref="M:DocumentModel.Attributes.SchemaAttrAttribute.#ctor(System.String,System.String)" /></remarks>
    public SchemaAttrAttribute(string qname)
    {
      if (string.IsNullOrEmpty(qname))
        throw new ArgumentNullException(nameof(qname));
      var ss = qname.Split(':');
      if (ss.Length == 2)
        this._qname = new XmlQualifiedName(ss[1],ss[0]);
      else
        this._qname = new XmlQualifiedName(qname);
    }

    /// <summary>
    /// Initializes a new instance of the SchemaAttrAttribute.
    /// </summary>
    /// <param name="ns">Specifies the namespace of the schema attribute.</param>
    /// <param name="tag">Specifies the Tag name of the schema attribute.</param>
    public SchemaAttrAttribute(string ns, string tag)
    {
      if (string.IsNullOrEmpty(tag))
        throw new ArgumentNullException(nameof (tag));
      this._qname = new XmlQualifiedName(ns, tag);
    }

    /// <summary>Gets the tag name of the schema attribute.</summary>
    public string Tag => this._qname.Name;

    /// <summary>Gets the Namespace of the schema attribute.</summary>
    public string Namespace => this._qname.Namespace;
  }
}
