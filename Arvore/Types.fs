module Types

//Alias
type Date = System.DateTime
type NF = string
type PostoFiscal = string

type Modal = 
    | Aqua
    | Aereo
    | Rodo
    | Multimodal

type DocumentoBase =
    | MDFComposto of MDFComposto //MDF áqua ou aéreo
    | MDFSimples of MDFSimples //MDF rodo
    | CL of CL

and CT = {
    CNPJEmitente: int
    RSEmitente: string
    Modal: Modal
    DocsReferenciados: DocsReferenciadosCT
}

and DocsReferenciadosCT =
    | NFs of NF[]
    | CT of CT

and MDFComposto = {
    PF: PostoFiscal
    DataApresentacao: Date
    CNPJEmitente: int
    RSEmitente: string
    Modal: Modal
    DocsReferenciados: DocsReferenciadosMDFComposto
}

and DocsReferenciadosMDFComposto =
    | NFs of NF[]
    | CTs of CT[]
    | ``NFs e CTs`` of NF[] * CT[]

and MDFSimples = {
    PF: PostoFiscal
    DataApresentacao: Date
    CNPJEmitente: int
    RSEmitente: string
    Modal: Modal
    DocsReferenciados: DocsReferenciadosMDFSimples
}

and DocsReferenciadosMDFSimples =
    | NFs of NF[]
    | CTs of CT[]

and CL = {
    PF: PostoFiscal
    DataApresentacao: Date
    NFs: NF[]
}

