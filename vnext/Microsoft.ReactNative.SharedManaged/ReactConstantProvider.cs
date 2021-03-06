// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.ReactNative.Managed
{
  class ReactConstantProvider
  {
    public ReactConstantProvider(IJSValueWriter writer)
    {
      m_writer = writer;
    }

    public void Add<T>(string constantName, T value)
    {
      m_writer.WriteObjectProperty(constantName, value);
    }

    private IJSValueWriter m_writer;
  }
}
