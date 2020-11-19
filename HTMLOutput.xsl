<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="html"></xsl:output>
  <xsl:template match="/">
    <html>
      <body>
        <table border="2">
          <TR>
            <th>Artist</th>
            <th>Album</th>
            <th>Year</th>
            <th>Genre</th>
            <th>Name</th>
            <th>Duration</th>
            <th>Likes</th>
            <th>Plays</th>
          </TR>
          <xsl:for-each select="Tracks/Track">
            <tr>
              <td>
                <xsl:value-of select="@Artist"/>
              </td>
              <td>
                <xsl:value-of select="@Album"/>
              </td>
              <td>
                <xsl:value-of select="@Year"/>
              </td>
              <td>
                <xsl:value-of select="@Genre"/>
              </td>
              <td>
                <xsl:value-of select="@Name"/>
              </td>
              <td>
                <xsl:value-of select="@Duration"/>
              </td>
              <td>
                <xsl:value-of select="@Likes"/>
              </td>
              <td>
                <xsl:value-of select="@Plays"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>