# **Singleton / MonoState**

## Propósito
Garantir a singularidade de uma classe para que a mesma tenha apenas uma instância.


## Singleton
O Singleton é um padrão de projeto criacional que permite a você garantir que uma classe tenha apenas uma instância, enquanto provê um ponto de acesso global para essa instância.

### Prós 
- Aplicável: podemos alterar qualquer classe para Singleton simplesmente tornando seus construtores privados e adicionando as funções e variáveis estáticas apropriadas.
- Pode ser criado por derivação: Dada uma classe, você pode criar uma subclasse Singleton.
- Avaliação Lenta: Se o Singleton nunca é usado, ele nunca é criado.

### Contras
- A destruição é indefinida. Não há uma boa maneira de destruir ou desativar um Singleton. Se você adiciona um método de destruição que anule o método Instance,
outros módulos do sistema ainda podem conter uma referência para o SINGLETON. As chamadas subsequentes para Instance farão com que outra instância seja criada, fazendo com que existam duas instâncias simultâneas.
- Não é herdado. Uma classe derivada de um Singleton não é um Singleton. Se precisar ser um Singleton, a função estática e a variável precisam ser adicionadas a ele.
- Eficiência. Cada chamada para Instance chama a instrução if. Para a maioria dessas chamadas, a instrução if é inútil.
- Não transparente. Os usuários de um Singleton sabem que estão usando um Singleton porque devem invocar o método Instance.
- O padrão Singleton pode mascarar um design ruim, por exemplo, quando os componentes do programa sabem muito sobre cada um.

---

## MonoState
O MonoState, tenta esconder o fato de que a classe somente opera com uma instância única de dados usando membros estáticos. Por isso, todos os membros de um MonoState são estáticos e todas as suas instâncias usam esse dado estático. As aplicações que usam o padrão MonoState, podem criar qualquer número de instâncias que desejarem e cada uma delas usará o mesmo dado.

### Prós 
- Transparência. Os usuários de um MonoState não se comportam de maneira diferente dos usuários de um objeto comum. Os usuários não precisam saber que o objeto é MonoState.
- Derivabilidade. Derivados de um MonoState são MonoState. De fato, todos os derivados de um MonoState fazem parte do mesmo MonoState. Todos eles compartilham as mesmas variáveis estáticas.
- Polimorfismo. Como os métodos de um MonoState não são estáticos, eles podem ser substituídos em um derivado. Assim, diferentes derivadas podem oferecer diferentes comportamentos sobre o mesmo conjunto de variáveis estáticas.
- Criação e destruição bem definidas. As variáveis de um MonoState, sendo estáticas, possuem tempos de criação e destruição bem definidos.

### Contras
- Nenhuma conversão. Uma classe normal não pode ser convertida em uma classe MonoState por derivação.
- Eficiência. Um MonoState pode passar por muitas criações e destruições porque é um objeto real. Essas operações costumam ser caras.
- Presença. As variáveis de um MonoState ocupam espaço, mesmo que o MonoState nunca seja usado.

---

## Singleton x MonoState: Qual e quando usar?
Devemos usar o padrão Singleton quando temos uma classe e desejamos restringir por meio de derivação e não importa se todos tenham que chamar o método Instance() para este acesso. O padrão MonoState deve ser usado quando queremos uma natureza singular de uma determinada classe e que seja transparente para os usuários quando for usar derivadas polimórficas de um único objeto.