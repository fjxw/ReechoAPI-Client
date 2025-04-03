import { Label } from "@/components/ui/label";
import { Button } from "@/components/ui/button";
import { Input } from "@/components/ui/input";
import { Search } from "lucide-react";
import { useNavigate } from "react-router";


export const SearchHeader = () => {
    const navigate = useNavigate()
    return (
        <div className="container mx-auto px-20 my-5 flex flex-wrap gap-3">
            <Label className="text-3xl font-bold flex-grow">
                Reecho
            </Label>
            <div className="flex gap-1 flex-grow lg:w-1/2">
                <Input placeholder="Поиск..." />
                <Button>
                    <Search />
                </Button>
            </div>
            <div className="flex gap-1.5 flex-grow justify-end">
                <Button variant="secondary" onClick={() => navigate("login")} >
                    Вход
                </Button>
                <Button onClick={() => navigate("register")}>Регистрация</Button>
            </div>
        </div>
        
        
    );
};
