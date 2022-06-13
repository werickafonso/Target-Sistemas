//# Target-Sistemas
//Teste de Programação

//Questão numero 1


{
    unsigned vet[4];
    unsigned int i;    
    vet[0]=0;
    vet[1]=1;
    vet[2]=0;
    vet[3]=0;
 
    printf("Informe o numero a ser comparado:");
    scanf("%u", &vet[3]);
    for (i=0;i<vet[3];i++)
    {    
        vet[2] = vet[0] + vet[1];
        if(vet[2] == vet[3])
        {
            printf("O valor pertence a sequência Fibonacci");            
            return 0;
        }
        vet[0] = vet[1];
        vet[1] = vet[2];
    }
    printf("O valor não pertence a sequência Fibonacci");
    return 0;
}




