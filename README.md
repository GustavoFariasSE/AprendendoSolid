Este projeto demonstra a aplicação de princípios SOLID na implementação de um sistema de cálculo de descontos baseado em status do cliente e tempo de fidelidade.
O objetivo é manter o código aberto para extensão e fechado para modificação, tornando-o flexível, limpo e de fácil manutenção.

🚀 Objetivo

Calcular o preço final de um produto após aplicar:

1. Um desconto baseado no status da conta do cliente (Comum, Especial, VIP, etc.).
2. Um desconto adicional de fidelidade, conforme o tempo que o cliente possui a conta.

Cada tipo de cliente tem sua própria regra de desconto:

- ClienteNaoRegistradoDesconto → sem desconto
- ClienteComumDesconto → 10%
- ClienteEspecialDesconto → 20%
- ClienteVIPDesconto → 30%
