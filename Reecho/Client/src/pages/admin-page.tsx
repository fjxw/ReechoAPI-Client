import {Label} from "@/components/ui/label.tsx";
import {Input} from "@/components/ui/input.tsx";
import {Button} from "@/components/ui/button.tsx";

export const AdminPage = () => {
    return (
        <>
            <div className="my-5 mx-5 flex flex-col gap-2"> 
                <Label className="text-3xl font-bold">Страница администрирования</Label>
                <div className="flex flex-col gap-2">
                    <Label className="text-xl opacity-40">Добавление элемента</Label>
                    <Label>Название</Label>
                    <Label>Цена</Label>
                    <Label>Изображение</Label>
                </div>
                <div className="flex flex-col gap-2">
                    <Label className="text-xl opacity-40">Удаление элемента</Label>
                    <Label>ID</Label>
                    <Input/>
                    <Button></Button>
                </div>
               
            </div>
    
        </> 
    )
}