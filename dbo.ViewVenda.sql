CREATE VIEW [dbo].[ViewVenda]
		AS SELECT     dbo.Produto.Nome, dbo.Produto.Texto, dbo.CompraProduto.Quantidade, dbo.Produto.Preco, dbo.Compra.Id
FROM         dbo.CompraProduto INNER JOIN
             dbo.Produto ON dbo.Produto.Id = dbo.CompraProduto.IdProduto INNER JOIN
             dbo.Compra ON dbo.Compra.CodReferencia = dbo.CompraProduto.CodReferencia