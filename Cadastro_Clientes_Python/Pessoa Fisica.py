import Clientes



class PessoaFisica(Clientes):
    def __init__(self, nome, cpf, datanascimento):
        super().__init__(nome)
        self.cpf = cpf
        self.datanascimento = datanascimento

    def setCPF(self, cpf):
        self.cpf = cpf
    def setDataNascimento(self, datanascimento):
        self.datanascimento = datanascimento
    def getCPF(self):
        return self.cpf
    def getDataNascimento(self):
        return self.datanascimento



