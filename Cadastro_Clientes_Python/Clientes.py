class Clientes:
    def __init__(self, nome, valor, valorimposto, total):
        self.nome = nome
        self._valor = valor
        self._valorimposto = valorimposto
        self._total = total

    def setNome (self, nome):
        self.nome = nome

    def setValor (self, valor):
        self._valor = valor
    def setValor_Imposto(self, valorimposto, valor):

        self._valorimposto = valor*(10/100)
    def setTotal(self, total):
        self._total = total
    def getNome (self):
        return self.nome
    def getValor(self):
        return self._valor
    def getValor_Imposto(self):
        return self._valorimposto
    def getTotal(self):
        return self._total


