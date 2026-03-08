export interface MainInterface<T>{
    count: number
    message:string
    searchCriteria: string
    results:T[]
}