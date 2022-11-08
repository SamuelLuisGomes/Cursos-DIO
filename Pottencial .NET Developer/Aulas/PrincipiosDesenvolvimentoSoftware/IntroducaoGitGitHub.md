# Introdução ao Git e ao Github

- Introdução ao Git
    
    
- Navegação via command line interface e instalação
    - Comandos Básicos
        
        O Git é um CLI(Command Line Interface)
        
        - Comandos
            
            O comando del no windows só exclui arquivos e não pastas, para excluir uma pasta termos que usar rmdir.
            
            del ⇒ Exclui arquivos.
            
            rmdir⇒ Exclui pastas com seus arquivos.
            
    - Realizando Instalação do GIT
        
        [Git](https://git-scm.com/)
        
    - 
- Entendendo como o Git funciona por baixo dos panos **(Rever Futuramente)**
    - Objetos internos do Git
        
        O Git possui 3 objetos:
        
        - BLOBS (Bolha)
            
            Ele é um objeto que contem meta dados dentro dele, dessa forma
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%201.png)
            
            Nesse caso está sendo feito a encriptação da mesma forma, só que na 1° parte com o objeto e na segunda de forma crua, eles ficam diferentes por causa dos meta dados armazenados por padrão no objeto.
            
            A diferença é no objeto BLOBS temos
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%202.png)
            
            Por causa do Blob e da \0 que os caracteres da encriptação são diferentes.
            
             Se fizermos a encriptação com os caracteres correspondentes eles ficaram iguais, veja a imagem a seguir:
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%203.png)
            
        - TREES (Árvore)
            
            As tree armazenas os blobs e também tem meta dados
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%204.png)
            
            Exemplo de como funciona a tree
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%205.png)
            
        - COMMITS
            
            Ele é o mais importante, ele junta tudo e faz com que a alteração que estamos fazendo faça sentido.
            
            Ele aponta para uma tree, parente(Último commit realizado antes do atual), autor, mensagem
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%206.png)
            
            O autor é o nome de quem está fazendo o mesmo.
            
            Sempre que alterarmos alguma coisa será feita uma alteração, com isso vai sendo criado um histórico de alterações.
            
            ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled%207.png)
            
    - Chave SSH e Token
        - Chave SSH
            
            
- Primeiros comandos com Git
    
    ![Untitled](Introduc%CC%A7a%CC%83o%20ao%20Git%20e%20ao%20Github%20fac4d8616fe74dcc9d0f4156f76513c0/Untitled.png)
    
    mkdir ⇒ Cria uma nova pasta.
    
    pwd ⇒ Mostra o caminha que está atualmente.
    
    clear ⇒ Limpa a tela.
    
    CTRL + L ⇒ Limpa a tela
    
    cd ⇒ Entra do diretório.
    
    dir ⇒ Lista os arquivos da pasta.
    
    ls ⇒ Lista os arquivos/pastas
    
    del ⇒ O comando del no windows só exclui arquivos e não pastas, para excluir uma pasta termos que usar rmdir.
    
    type ⇒ Cria um arquivo.
    
    git status ⇒ Mostra o status dos arquivos.
    
    mv ⇒ Move algum arquivo/pasta dentro do Git
    
    ```jsx
    //Sintaxe 
    type > macarrao.md
    ```
    
    Se usarmos o -a podemos mostrar arquivos ocultos
    
    ```jsx
    ls -a //Mostra os arquivos ocultos de uma pasta.
    ```
    
    - Configurando o Email e Name
        
        Se for a 1° vez que usamos o GitHub precisamos configurar o email e name.
        
        ```jsx
        //Podemos definir ela como global ou não
        //Email
        git config --global user.email "samuelluisgomestehc@gmail.com"
        //User
        git config --global user.name SamuelGomes
        ```
        
        Se for necessário excluir basta usar esse comando para listar:
        
        ```jsx
        // Lista as configurações do Git
        git config --list
        //Para sairmos da lista de configurações basta precionarmos 'q'
        ```
        
        Se precisarmos alterar tanto o email quanto o name basta excluirmos com esse comando:
        
        ```jsx
        //Excluindo os emails cadastrados
        git config --global --unset user.email
        //Excluindo os names cadastrados
        git config --global --unset user.name
        ```
        
        Depois disso teremos que nos identificar novamente!
        
- Ciclo de vida dos arquivos no Git **(Rever Futuramente)**
    
    
- Introdução ao Github **(Rever Futuramente)**
    
    Para conectarmos